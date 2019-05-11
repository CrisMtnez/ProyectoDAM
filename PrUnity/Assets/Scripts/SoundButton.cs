using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public static bool SOUNDSON = true;
    public Text soundText;

    void Start()
    {
        CheckIfSoundsOn();
    }

    public void OnClick()
    {
        FindObjectOfType<GameManager>().ClickSound();
        SOUNDSON = !SOUNDSON;
        CheckIfSoundsOn();
    }

    public void CheckIfSoundsOn()
    {
        soundText.text = SOUNDSON ? "Sounds On" : "Sounds Off";
    }
}
