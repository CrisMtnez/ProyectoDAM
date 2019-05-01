using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectaFinal : MonoBehaviour
{
    public GameObject texto;

    private void OnTriggerEnter()
    {
        texto.SetActive(true);
    }
}
