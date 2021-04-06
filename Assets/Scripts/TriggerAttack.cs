using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    public GameObject Bullet;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            Destroy(Bullet);
        }
    }

}
