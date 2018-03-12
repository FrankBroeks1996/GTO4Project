using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    public GameObject unit;
    public Grid grid;
	public List<ResourceCost> Resources;
    public ResourceController resourceController;

	public void InstantiateUnit()
    {
        if (AreResourcesSufficient())
        {
            Tile tile = grid.GetFirstEmptyTile();
            Instantiate(unit, new Vector3(tile.x, 2, tile.y), Quaternion.identity);
            tile.Occupied = true;
        }
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
            resourceController.RemoveResource(resource.resource, resource.cost);
        }
    }
}
