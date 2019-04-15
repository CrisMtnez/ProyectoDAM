using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;
    float secondsLeft = 601;

    // Update is called once per frame
    void Update()
    {
        if (secondsLeft > 0)
        {
            int min = (int)secondsLeft / 60;
            int sec = (int)secondsLeft % 60;
            secondsLeft -= Time.deltaTime;
            timer.text = String.Format("{0:00}:{1:00}", min, sec);                   
        }
        else
        {
            FindObjectOfType<PlayerMov>().alive = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
