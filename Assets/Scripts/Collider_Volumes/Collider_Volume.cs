
using UnityEngine;
using UnityEngine.EventSystems;

public class Collider_Volume : MonoBehaviour
{

    public GameLevel game_level;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //trigger
        game_level.Entered_EndRetro_Volume();

        //shutdown
        Destroy(this);
    }


}
