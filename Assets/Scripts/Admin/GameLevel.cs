using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameLevel : MonoBehaviour
{

    public GameObject gate;
    public Camera cam;
    public GameObject ball;
    public GameObject Player_1_Score;

    public string text_score;
    public int game_score = 0;
    
    
    private Text score_text;
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
        score_text = Player_1_Score.GetComponent<Text>();

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
        LevelInfo info = LevelHouse.BuildALevel(300);

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

    public void PauseGame()
    {
        //bring up menu screen

        Debug.Log("pause screen");
    }

    public void Change_Score(int num)
    {
        game_score += num;
        Score_Update();
    }

    public void Score_Update()
    {
        string updated_string;


        if(game_score < 10)
        {
            updated_string = "00" + game_score.ToString();
        }
        else if(game_score < 100)
        {
            updated_string = "0" + game_score.ToString();
        }
        else if(game_score < 1000)
        {
            updated_string = game_score.ToString();
        }
        else
        {
            updated_string = "999";
        }



        score_text.text = updated_string;

    }


}
