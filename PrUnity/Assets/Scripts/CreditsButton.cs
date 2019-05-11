using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : MonoBehaviour
{
    public void OnClick()
    {
        FindObjectOfType<GameManager>().ClickSound();
        FindObjectOfType<GameManager>().ShowCredits();
    }
}
