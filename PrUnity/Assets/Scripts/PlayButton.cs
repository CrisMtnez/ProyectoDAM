using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{    
    public void OnClick()
    {
        FindObjectOfType<GameManager>().ClickSound();
        GameManager.PLAYING = true;
        GameManager.crashSoundPlayed = false;
        SceneManager.LoadScene(1);
    }
}
