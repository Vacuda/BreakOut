using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ot_OBJECTTYPE;
using static bt_BRICKTYPE;

public class Ball : MonoBehaviour, ICanCollideWith
{
    Animator anim;
    Rigidbody2D r_body;
    public GameLevel game_level;
    public Retro_PlayerController controller;
    private BallMovement ball_movement;
    bool IsStuckToPaddle = false;

    Vector2 StoredVelocity;
    public ot_OBJECTTYPE object_type { get; set; } = ot_BALL;

    public bool IsKilledBySpikes = true;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        r_body = gameObject.GetComponent<Rigidbody2D>();
        ball_movement = gameObject.GetComponent<BallMovement>();
        StoredVelocity = new Vector2(0.0f, 0.0f);    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ICanCollideWith collided_object = collision.gameObject.GetComponent<ICanCollideWith>();

        if(collided_object != null)
        {
            if(collided_object.object_type == ot_SPIKE)
            {
                //Debug
                if (IsKilledBySpikes)
                {

                    EndGame();
                }


            }

            if(collided_object.object_type == ot_PADDLE)
            {
                if (controller.IsInCatchMode == true)
                {
                    //StoredVelocity = r_body.velocity;


                    IsStuckToPaddle = true;
                    r_body.simulated = false;
                    gameObject.transform.parent = collision.gameObject.transform;
                    ball_movement.enabled = false;
                }




            }
            //if brick
            if (collided_object.object_type == ot_BRICK)
            {
                bt_BRICKTYPE type = collision.gameObject.GetComponent<Brick>().brick_type;

                switch (type)
                {
                    case bt_YELLOW:
                        game_level.Change_Score(1);
                        break;
                    case bt_GREEN:
                        game_level.Change_Score(3);
                        break;
                    case bt_ORANGE:
                        game_level.Change_Score(5);
                        break;
                    case bt_RED:
                        game_level.Change_Score(7);
                        break;
                    default:
                        break;

                }
            }
        }
        
 

    }

    public void Release_Ball()
    {
        if (IsStuckToPaddle)
        {
            ball_movement.enabled = true;
            r_body.simulated = true;
            IsStuckToPaddle = false;
            gameObject.transform.parent = null;
        }

    }
    
    public void EndGame()
    {
        r_body.simulated = false;


        StartCoroutine(lava());
    }

    IEnumerator lava()
    {
        Debug.Log("DEESTORY");
        anim.Play("state_Exploding");

        yield return new WaitForSeconds(1.0f);

        game_level.Trigger_EndGame();




        yield break;
    }
}
