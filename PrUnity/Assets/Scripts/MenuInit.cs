﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(1))
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        GameManager.PLAYING = false;        
    }
}
