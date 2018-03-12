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
                grid[x, y] = Instantiate<Tile>(Tile, new Vector3(x, 1, y), Quaternion.identity);
            }
        }
    }
    
    public Tile GetFirstEmptyTile()
    {
        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                if(!grid[x, y].Occupied)
                {
                    return grid[x, y];
                }
            }
        }

        return null;
    }
}
