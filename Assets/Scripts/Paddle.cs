using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Retro_PlayerController retro_controller;


    /* STORAGE MEMBERS */
    float screen_width;
    float screen_height;
    float min_x_position = -16.625f;
    float max_x_position = 2.625f;
    float min_y_position = -10.21f;
    float max_y_position = 10.3f;
    float mouse_x;
    float mouse_y;
    float new_x;
    float new_y;
    Vector3 pos;

    PlayerControls Controls;

    public bool IsSidePaddle = false;

    private void Start()
    {
        //get controls
        Controls = retro_controller.Get_Controls();

        //if side paddle
        if (IsSidePaddle)
        {
            //make new position variable
            pos = new Vector3(gameObject.transform.position.x, 0.0f, 0.0f);
        }
        //if not side paddle
        else
        {
            //make new position variable
            pos = new Vector3(0.0f, gameObject.transform.position.y, 0.0f);
        }

        //get screen width
        screen_width = Screen.width;
        screen_height = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        Set_PaddlePosition();
        //gameObject.transform.position = ?;
    }

    void Set_PaddlePosition()
    {
        //if side paddle
        if (IsSidePaddle)
        {
            //get mouse_y
            mouse_y = Controls.RetroGame.Mouse_PointerLocation.ReadValue<Vector2>().y;

            //get new_x
            new_y = min_y_position + ((mouse_y / screen_height) * (max_y_position - min_y_position));

            //clamp, if necessary
            new_y = Mathf.Clamp(new_y, min_y_position, max_y_position);

            //change position
            pos.y = new_y;
        }
        //if not side paddle
        else
        {
            //get mouse_x
            mouse_x = Controls.RetroGame.Mouse_PointerLocation.ReadValue<Vector2>().x;

            //get new_x
            new_x = min_x_position + ((mouse_x / screen_width) * (max_x_position - min_x_position));

            //clamp, if necessary
            new_x = Mathf.Clamp(new_x, min_x_position, max_x_position);

            //change position
            pos.x = new_x;
        }

        //set new position
        gameObject.transform.position = pos;
    }

    public void Destroy_Paddle()
    {
        Destroy(gameObject);
    }
}
