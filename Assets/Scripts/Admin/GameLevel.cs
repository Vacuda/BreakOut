using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameLevel : MonoBehaviour
{

    public GameObject gate;
    public Camera cam;
    public GameObject ball;
    
    
    private LevelBuilder _level_builder;
    private MoverBase gate_mover;
    private MoverBase cam_mover;
    private BallMovement ball_movement;

    private void Awake()
    {
        gate_mover = gate.GetComponent<MoverBase>();
        cam_mover = cam.GetComponent<MoverBase>();
        ball_movement = ball.GetComponent<BallMovement>();
        _level_builder = gameObject.GetComponent<LevelBuilder>();
    }

    void Start()
    {
        StartCoroutine(StartUp());
    }

    IEnumerator StartUp()
    {
        //mini delay
        yield return new WaitForSeconds(0.01f);

        //build blank levelinfo
        LevelInfo info = LevelHouse.BuildALevel(3);

        //build level
        _level_builder.BuiltOut_ThisLevel(info);

        //reset gate
        gate_mover.InstantChange_ToTargetPosition();
        gate_mover.Swap_TargetAndStartPositions();

        yield break;
    }
    

    public void Entered_EndRetro_Volume()
    {
        cam_mover.Activate_Move();
    }

    IEnumerator SlowBall()
    {
        //slow ball
        ball_movement.ChangeSpeed_Slow();

        yield return new WaitForSeconds(0.7f);

        //return to normal speed
        ball_movement.ChangeSpeed_Normal();

        //end
        yield break;
    }

    public void Close_Gate()
    {
        StartCoroutine(SlowBall());

        gate_mover.Activate_Move();
    }

    public void Trigger_EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
