using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockSpawner : MonoBehaviour
{
    public GameObject tile_block;
    public Tilemap lava;

    // Start is called before the first frame update
    void Start()
    {
        MakeWalls();
    }

    void MakeWalls()
    {
        //full rows
        for(int x = -19; x <= 6; x++)
        {
            //top row
            MakeBlock(x, 13);

            //bottom row
            MakeBlock(x, -14);
        }

        //full sides
        for (int y = -14; y <= 13; y++)
        {
            //top row
            MakeBlock(-19, y);

            //bottom row
            MakeBlock(6, y);
        }

    }

    void MakeBlock(int x, int y)
    {
        //instantiate block
        GameObject block = Instantiate(tile_block);

        //set new vector
        Vector3Int grid_pos = new Vector3Int(x, y, 0);

        //get world pos
        Vector3 pos = lava.GetCellCenterWorld(grid_pos);

        //set position
        block.transform.position = pos;
    }
}
