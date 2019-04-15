using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaTrigger : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        FindObjectOfType<GameManager>().YouWin();
    }
}
