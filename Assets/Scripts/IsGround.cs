using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGround : MonoBehaviour
{
    public GameObject Player;


    void OnTriggerStay(Collider ground)
    {
        Player.GetComponent<Movement>().isGround = true;
    }

    void OnTriggerExit(Collider ground)
    {
        Player.GetComponent<Movement>().isGround = false;
    }
}
