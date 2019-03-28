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
            movement.enabled = false;
        }            
    }
}
