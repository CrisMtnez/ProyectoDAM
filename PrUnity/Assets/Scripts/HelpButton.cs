﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButton : MonoBehaviour
{
    public void OnClick()
    {
        FindObjectOfType<GameManager>().ShowHelp();
    }
}
