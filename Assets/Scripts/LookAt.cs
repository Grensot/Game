using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject Player;

    void FixedUpdate()
    {
        transform.LookAt(Player.transform.position);
    }
}
