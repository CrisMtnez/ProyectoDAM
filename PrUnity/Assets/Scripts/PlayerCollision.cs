using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMov movement;
    public GameEnds gameEnd;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "car")
        {
            Debug.Log("car crash");
            movement.kip.transform.rotation = new Quaternion(-24.868f, 63f, 143.849f, 0);
            movement.alive = false;
        }
        if (collision.collider.tag == "platform" || collision.collider.tag == "win")
            movement.yPos = collision.collider.transform.position.y + 0.1f;
        else
            movement.yPos = 0.25f;

        //if (collision.collider.tag == "win" && movement.yPos > collision.collider.transform.position.y)
            
    }
}
