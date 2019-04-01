﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMov : MonoBehaviour
{
    public Rigidbody car;
    public Transform trCar;
    public float endRoad = 50;
    public float y;

    void Start()
    {
        y = car.position.y;
        car.transform.position = new Vector3(car.position.x, y, car.position.z);        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (trCar.position.x >= endRoad)
        {
            Debug.Log("sobresale la carretera");
            car.transform.position = new Vector3(-endRoad, y, car.position.z);
        }
        else
        {
            car.transform.position = new Vector3((float)(car.position.x + 0.5), y, car.position.z);
        }            
    }
}
