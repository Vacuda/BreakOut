using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{

    public GameObject gate;
    public Camera cam;
    public GameObject ball;
    
    
    private BlockSpawner _blockspawner;
    private MoverBase gate_mover;
    private MoverBase cam_mover;
    private BallMovement ball_movement;

    private void Awake()
    {
        gate_mover = gate.GetComponent<MoverBase>();
        cam_mover = cam.GetComponent<MoverBase>();
        ball_movement = ball.GetComponent<BallMovement>();
        _blockspawner = gameObject.GetComponent<BlockSpawner>();
    }

    void Start()
    {
        LevelInfo info = LevelBuilder.BuildALevel();

        _blockspawner.BuiltOut_ThisLevel(info);


        //reset gate
        gate_mover.InstantChange_ToTargetPosition();
        gate_mover.Swap_TargetAndStartPositions();
    }
    

    public void Entered_EndRetro_Volume()
    {
        gate_mover.Activate_Move();
        cam_mover.Activate_Move();

        StartCoroutine(SlowBall());
    }

    IEnumerator SlowBall()
    {
        yield return new WaitForSeconds(0.20f);

        //slow ball
        ball_movement.ChangeSpeed_Slow();

        yield return new WaitForSeconds(1);

        //return to normal speed
        ball_movement.ChangeSpeed_Normal();

        //end
        yield break;
    }


}
