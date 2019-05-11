using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public GameObject areYouSure;

    public void Sound()
    {
        FindObjectOfType<GameManager>().ClickSound();
    }

    public void OnClick()
    {        
        Sound();
        Application.Quit();        
    }

    public void OnPlaying()
    {
        Sound();
        FindObjectOfType<GameManager>().helpPanel.SetActive(false);        
        areYouSure.SetActive(true);
    }

    public void YesButton()
    {        
        SceneManager.LoadScene(1);
        GameManager.PLAYING = false;
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
        FindObjectOfType<SoundButton>().CheckIfSoundsOn();
        if (SoundButton.SOUNDSON)
            Sound();
    }

    public void NoButton()
    {
        Sound();
        areYouSure.SetActive(false);
        FindObjectOfType<GameManager>().ResumeGame();
    }

    public void Restart()
    {
        Sound();
        GameManager.PLAYING = true;
        areYouSure.SetActive(false);
        GameManager.crashSoundPlayed = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
