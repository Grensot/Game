using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleDisap : MonoBehaviour
{
    public GameObject Obj;
    public GameObject Player;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            Player.transform.position = Obj.transform.position;
            Destroy(Obj);
        }
    }
}
