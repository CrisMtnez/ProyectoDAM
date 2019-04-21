using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform kip;
    public Vector3 offset;
       
    void FixedUpdate()
    {
        transform.position = kip.position + offset;
    }
}
