using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour
{
    public Rigidbody car;
    public Rigidbody road;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        car.AddForce(1000 * Time.deltaTime, 0, 0);
    }
}
