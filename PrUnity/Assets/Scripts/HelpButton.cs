using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpButton : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject helpPanel;

    public void OnClick()
    {
        FindObjectOfType<GameManager>().ShowHelp();        
    }

    public void OnMenuClick()
    {
        menuPanel.SetActive(false);
        helpPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        menuPanel.SetActive(true);
        helpPanel.SetActive(false);
    }
}
