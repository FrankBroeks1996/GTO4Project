using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public Player player;
    public GameObject unit;
    public Grid grid;
	public List<ResourceCost> Resources;
    public ResourceController resourceController;

	public GameObject InstantiateUnit()
    {
        if (AreResourcesSufficient())
        {
            Tile tile = grid.GetFirstEmptyTile();
            GameObject newUnit = Instantiate(unit, new Vector3(tile.x, 2, tile.y), Quaternion.identity);
            newUnit.transform.parent = tile.transform;
            newUnit.GetComponent<Unit>().tile = tile;
            tile.UnitOnTile = newUnit.GetComponent<Unit>();
            return newUnit;
        }
        return null;
    }

    [System.Serializable]
    public struct ResourceCost
    {
        public ResourceModel resource;
        public int cost;
    }

    public bool AreResourcesSufficient()
    {
        foreach (ResourceCost resource in Resources)
        {
            if(resource.resource.CurrentOwned < resource.cost)
            {
                return false;
            }
        }

        return true;
    }

    public void PayResources()
    {
        foreach (ResourceCost resource in Resources)
        {
            resourceController.RemoveResource(resource.resource);
        }
    }
}
