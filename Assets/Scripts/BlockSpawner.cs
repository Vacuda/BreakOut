using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BlockSpawner : MonoBehaviour
{
    public GameObject PF_Wall;
    public GameObject PF_Spike;
    public Tilemap _tilemap;
    public GameObject gate;


    /* TEMP MEMBERS */
    Vector3Int grid_pos;
    Vector3 pos;
    Quaternion rot;

    private void Awake()
    {
        grid_pos = new Vector3Int(0, 0, 0);
        pos = new Vector3(0.0f, 0.0f, 0.0f);
        rot = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
    }

    void Start()
    {

    }

    public void BuiltOut_ThisLevel(LevelInfo info)
    {

        MakeGate();
        MakeWalls(info);





    }

    void MakeGate()
    {
        //full rows
        for (int x = -18; x <= 3; x++)
        {
            //top row, attach to gate
            MakeBlock(x, 14, true);

            //top row, attach to gate
            MakeBlock(x, 13, true);
        }

        //side spikes
        MakeSpike(-19,14, 90, true);
        MakeSpike(-19,13, 90, true);
    }

    void MakeWalls(LevelInfo info)
    {
        //sides
        {
            int runner = 0;

            //full sides
            for (int y = 12; y >= -13; y--)
            {
                //if wall
                if (info.wall_left_array[runner] == 0)
                {
                    //left col
                    MakeBlock(-20, y);

                    //right col
                    MakeBlock(-19, y);
                }

                //if wall
                if (info.wall_right_array[runner] == 0)
                {
                    //left col
                    MakeBlock(4, y);

                    //right col
                    MakeBlock(5, y);
                }

                //increment runner
                runner++;
            }
        }

        //bottom
        {
            int runner = 0;

            //full rows
            for (int x = -18; x <= 3; x++)
            {
                //if wall
                if(info.wall_bottom_array[runner] == 0)
                {
                    //top row
                    MakeBlock(x, -14);

                    //bottom row
                    MakeBlock(x, -15);
                }

                //increment runner
                runner++;
            }
        }
    }

    void MakeSpikes()
    {
        //full rows
        for (int x = -17; x <= 2; x++)
        {
            //top row, attach to gate
            MakeSpike(x, 12, 180, true);

            //bottom row
            MakeSpike(x, -13, 0);
        }

        //full sides
        for (int y = -12; y <= 11; y++)
        {
            //left col
            MakeSpike(-18, y, 270);

            //right col
            MakeSpike(3, y, 90);
        }
    }

    void MakeSpike(int x, int y, int rotation, bool attachToGate = false)
    {
        //instantiate block
        GameObject spike = Instantiate(PF_Spike);

        //change grid values
        grid_pos.x = x;
        grid_pos.y = y;

        //get world pos
        pos = _tilemap.GetCellCenterWorld(grid_pos);

        //set position
        spike.transform.position = pos;

        //set rotation
        spike.transform.Rotate(0, 0, rotation);

        //if need to attach to gate
        if (attachToGate)
        {
            spike.transform.parent = gate.transform;
        }
    }

    void MakeBlock(int x, int y, bool attachToGate = false)
    {
        //instantiate block
        GameObject block = Instantiate(PF_Wall);

        //change grid values
        grid_pos.x = x;
        grid_pos.y = y;

        //get world pos
        pos = _tilemap.GetCellCenterWorld(grid_pos);

        //set position
        block.transform.position = pos;

        //if need to attach to gate
        if (attachToGate)
        {
            block.transform.parent = gate.transform;
        }
    }
}
