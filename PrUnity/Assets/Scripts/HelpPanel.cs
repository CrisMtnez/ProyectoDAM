using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpPanel : MonoBehaviour
{
    public void onBackClick()
    {
        FindObjectOfType<GameManager>().HideHelp();
    }
}
