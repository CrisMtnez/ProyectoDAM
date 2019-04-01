using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody kip;
    public bool saltando = false;
    float y;
    // Start is called before the first frame update
    void Start()
    {
        y = kip.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
            kip.AddForce(0, 0, -20 * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.UpArrow))
            kip.AddForce(0, 0, 20 * Time.deltaTime, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.LeftArrow))
            kip.AddForce(-20 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.RightArrow))
            kip.AddForce(20 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        if (Input.GetKey(KeyCode.Space) && kip.position.y <= y)
        {            
            saltando = true;
        }
        if (saltando && kip.position.y <= 0.5)
            kip.AddForce(0, 20 * Time.deltaTime, 0, ForceMode.VelocityChange);
        else
            saltando = false;
    }
}
