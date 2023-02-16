using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retro_PlayerController : MonoBehaviour
{

    //place to store controls
    protected PlayerControls Controls;



    /*ADMIN FUNCTIONS*/

    private void Awake()
    {
        //creates new control object
        Controls = new PlayerControls();

        //clear cursor
        Cursor.visible = false;
    }

    void Start()
    {
        Controls.RetroGame.Mouse_LeftButton.performed += _ => OnLeftButton();
        Controls.RetroGame.Mouse_RightButton.performed += _ => OnRightButton();
    }

    public PlayerControls Get_Controls()
    {
        return Controls;
    }

    void OnLeftButton()
    {

    }

    void OnRightButton()
    {

    }

    //enables controls when this script is active
    private void OnEnable()
    {
        Controls.Enable();
    }

    //disable controls when this script is inactive
    private void OnDisable()
    {
        Controls.Disable();
    }

}
