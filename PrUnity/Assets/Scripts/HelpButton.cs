using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject helpPanel;

    public void Sound()
    {
        FindObjectOfType<GameManager>().ClickSound();
    }

    public void OnClick()
    {
        Sound();
        FindObjectOfType<GameManager>().ShowHelp();        
    }

    public void OnMenuClick()
    {
        Sound();
        menuPanel.SetActive(false);
        helpPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        Sound();
        menuPanel.SetActive(true);
        helpPanel.SetActive(false);
    }
}
