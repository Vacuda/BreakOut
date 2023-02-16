using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelBuilder
{
    public static LevelInfo BuildALevel()
    {
        LevelInfo info = new LevelInfo();

        //find door
        {
            //initialize rand
            int rand;

            //get side
            switch (Random.Range(1, 4)) //1-3
            {
                //left
                case 1:
                    //get rand
                    rand = Random.Range(0, 25);  //0-24

                    Debug.Log(rand);

                    //set as doors
                    info.wall_left_array[rand] = 1;
                    info.wall_left_array[rand+1] = 1;

                    Debug.Log("left");
                    break;

                //right
                case 2:
                    //get rand
                    rand = Random.Range(0, 25);  //0-24

                    Debug.Log(rand);

                    //set as doors
                    info.wall_right_array[rand] = 1;
                    info.wall_right_array[rand + 1] = 1;

                    Debug.Log("right");
                    break;

                //bottom
                case 3:
                    //get rand
                    rand = Random.Range(0, 21);  //0-20

                    Debug.Log(rand);

                    //set as doors
                    info.wall_bottom_array[rand] = 1;
                    info.wall_bottom_array[rand + 1] = 1;

                    Debug.Log("bottom");
                    break;

                default:
                    rand = -1;
                    break;
            }
        }






        return info;
    }
}
