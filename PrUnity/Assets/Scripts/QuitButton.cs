using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
    public GameObject areYouSure;

    public void OnClick()
    {
        Application.Quit();        
    }

    public void OnPlaying()
    {
        //PONER JUEGO EN PAUSA
        areYouSure.SetActive(true);        
    }

    public void YesButton()
    {
        SceneManager.LoadScene(1);
        GameManager.PLAYING = false;
        SceneManager.LoadScene(0, LoadSceneMode.Additive);
    }

    public void NoButton()
    {
        areYouSure.SetActive(false);
    }

    public void Restart()
    {
        areYouSure.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
