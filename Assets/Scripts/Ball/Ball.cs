using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ot_OBJECTTYPE;

public class Ball : MonoBehaviour, ICanCollideWith
{
    Animator anim;
    Rigidbody2D r_body;
    public ot_OBJECTTYPE object_type { get; set; } = ot_BALL;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        r_body = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ICanCollideWith lava = collision.gameObject.GetComponent<ICanCollideWith>();

        if(lava != null)
        {
            if(lava.object_type == ot_SPIKE)
            {
                EndGame();
            }

            if(lava.object_type == ot_WALL)
            {
                Debug.Log("wall");
            }
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


        //shutdown
        Destroy(gameObject);



        yield break;
    }
}
