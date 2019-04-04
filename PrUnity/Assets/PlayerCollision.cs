using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMov movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "car")
        {
            Debug.Log("car crash");
            movement.kip.transform.rotation = new Quaternion(-1.56f, -188.614f, 270.403f, 0);
            movement.alive = false;
        }            
    }
}
