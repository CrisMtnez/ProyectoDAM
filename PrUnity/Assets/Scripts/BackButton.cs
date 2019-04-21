using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject pB, oB, qB, cB, bB, sB, rB;

    public void OnClick()
    {
        cB.SetActive(false);
        sB.SetActive(false);
        rB.SetActive(false);
        bB.SetActive(false);
        pB.SetActive(true);
        oB.SetActive(true);
        qB.SetActive(true);        
    }
}
