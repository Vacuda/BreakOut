using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Retro_PlayerController retro_controller;


    /* STORAGE MEMBERS */
    float screen_width;
    float min_position = -16.625f;
    float max_position = 2.625f;
    float mouse_x;
    float new_x;
    Vector3 pos;

    PlayerControls Controls;
    //private float y_position;

    private void Start()
    {
        //get controls
        Controls = retro_controller.Get_Controls();

        //make new position variable
        pos = new Vector3(0.0f, gameObject.transform.position.y, 0.0f);

        //get screen width
        screen_width = Screen.width;
    }

    // Update is called once per frame
    void Update()
    {
        Set_PaddlePosition();
        //gameObject.transform.position = ?;
    }

    void Set_PaddlePosition()
    {
        //get mouse_x
        mouse_x = Controls.RetroGame.Mouse_PointerLocation.ReadValue<Vector2>().x;

        //get new_x
        new_x = min_position + ((mouse_x / screen_width) * (max_position - min_position));

        //clamp, if necessary
        new_x = Mathf.Clamp(new_x, min_position, max_position);

        //change position
        pos.x = new_x;

        //set new position
        gameObject.transform.position = pos;
    }

    public void Destroy_Paddle()
    {
        Destroy(gameObject);
    }
}
