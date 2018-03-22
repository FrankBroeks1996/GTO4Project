using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour {

    public int Size;
    public Tile Tile;
    private Tile[,] grid;

    // Use this for initialization
    void Start()
    {
        grid = new Tile[Size, Size];
        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                grid[x, y] = Instantiate<Tile>(Tile, new Vector3(x + 0.15f * x, 1, y + 0.15f * y), Quaternion.identity);
            }
        }
    }
    
    public Tile GetFirstEmptyTile()
    {
        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                if(grid[x, y].UnitOnTile == null)
                {
                    return grid[x, y];
                }
            }
        }

        return null;
    }

    public int GetDistanceBetweenTiles(Tile startTile, Tile endTile)
    {
        Vector2 firstTile = new Vector2(-1, -1);
        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                if (grid[x, y] == startTile || grid[x, y] == endTile)
                {
                    if (firstTile == new Vector2(-1, -1))
                    {
                        firstTile = new Vector2(x, y);
                    }
                    else
                    {
                        return (int)Mathf.Abs(firstTile.x - x) + (int)Mathf.Abs(firstTile.y - y);
                    }
                }
            }
        }
        return 0;
    }
}
