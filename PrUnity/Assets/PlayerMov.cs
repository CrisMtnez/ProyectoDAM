using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody kip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow))
            kip.AddForce(0, 0, -500 * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            kip.AddForce(0, 0, 500 * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            kip.AddForce(-500 * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            kip.AddForce(500 * Time.deltaTime, 0, 0);
        //if (Input.GetKey(KeyCode.Space))                  CAMBIAR para que no sea constante
        //    kip.AddForce(0, 500 * Time.deltaTime, 0);
    }
}
