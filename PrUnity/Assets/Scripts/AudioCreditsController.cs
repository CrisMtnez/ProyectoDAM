using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioCreditsController : MonoBehaviour
{
    public AudioSource audio;
    public GameObject creditsText;

    void Start()
    {
        if (!SoundButton.SOUNDSON)
            audio.Stop();  
    }

    void FixedUpdate()
    {
    }
}
