using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody kip;
    public bool saltando = false;
    float y = 0.21f;
    public bool alive = true;
    private bool bamboleo = true;
    private float flow = 0.02f;
    // Start is called before the first frame update
    void Start()
    {
        //y = kip.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (alive)
        {
            //usamos ifs porque con case no funciona
            //float z = kip.transform.position.x % 2 == 0 ? 10:-10;
            bamboleo = !bamboleo;
            

            if (Input.GetKey(KeyCode.Space) && kip.position.y <= y)
                saltando = true;
            if (saltando && kip.position.y <= 0.5)
                kip.AddForce(0, 20 * Time.deltaTime, 0, ForceMode.VelocityChange);
            else
                saltando = false;

            if (Input.GetKey(KeyCode.DownArrow))
            {
                kip.transform.rotation = new Quaternion(bamboleo?flow:-flow, 1.2f, kip.transform.rotation.z, kip.transform.rotation.w);
                kip.AddForce(0, 0, -10 * Time.deltaTime, ForceMode.VelocityChange);
                Debug.Log("rot: " + kip.transform.localRotation.ToString());
            }
                
            if (Input.GetKey(KeyCode.UpArrow))
            {
                kip.transform.rotation = new Quaternion(bamboleo ? flow : -flow, 0, kip.transform.rotation.z, kip.transform.rotation.w);
                kip.AddForce(0, 0, 10 * Time.deltaTime, ForceMode.VelocityChange);
                Debug.Log("rot: " + kip.transform.localRotation.ToString());
            }
                
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                kip.transform.rotation = new Quaternion(bamboleo ? flow : -flow, -0.7f, kip.transform.rotation.z, transform.rotation.w);
                kip.AddForce(-10 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("rot: " + kip.transform.localRotation.ToString());
            }
                
            if (Input.GetKey(KeyCode.RightArrow))
            {
                kip.transform.rotation = new Quaternion(bamboleo ? flow : -flow, 0.7f, kip.transform.rotation.z, transform.rotation.w);
                kip.AddForce(10 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                Debug.Log("rot: " + kip.transform.localRotation.ToString());
            }                
        }
    }
}


/*
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
*/