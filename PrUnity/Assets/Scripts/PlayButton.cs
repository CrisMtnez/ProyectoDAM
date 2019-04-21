using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.PLAYING = true;
        SceneManager.LoadScene(1);
    }
}
