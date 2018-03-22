using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionHandler : MonoBehaviour {

    public Camera MainCamera;
    public Unit SelectedUnit;
    public Grid TileGrid;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = MainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit, 100f, LayerMask.GetMask("Grid")))
            {
                Tile clickedTile = raycastHit.collider.GetComponent<Tile>();
                if (clickedTile != null)
                {
                    if (clickedTile.UnitOnTile != null)
                    {
                        clickedTile.HighLight();
                        SelectedUnit = clickedTile.UnitOnTile;
                    }
                    else if(SelectedUnit != null)
                    {
                        if (TileGrid.GetDistanceBetweenTiles(clickedTile, SelectedUnit.tile) <= SelectedUnit.MovementCount)
                        {
                            SelectedUnit.transform.parent = clickedTile.transform;
                            SelectedUnit.transform.position = new Vector3(clickedTile.x, 2, clickedTile.y);
                            clickedTile.UnitOnTile = SelectedUnit;
                            SelectedUnit.tile.HighLight();
                            SelectedUnit.tile.UnitOnTile = null;
                            SelectedUnit.tile = clickedTile;
                            SelectedUnit = null;
                        }
                    }
                }
            }
        }
	}   
}
