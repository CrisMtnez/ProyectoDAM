using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public GameObject pB, oB, qB, cB, bB, sB, rB;

    public void OnClick()
    {
        FindObjectOfType<GameManager>().ClickSound();
        pB.SetActive(false);
        oB.SetActive(false);
        qB.SetActive(false);
        cB.SetActive(true);
        sB.SetActive(true);
        rB.SetActive(true);
        bB.SetActive(true);
    }
}
