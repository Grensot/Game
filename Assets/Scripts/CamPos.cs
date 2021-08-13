using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamPos : MonoBehaviour
{
    public Transform cam;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CamPos")
        {
            cam.transform.position = transform.position;
            Debug.Log("Тут я");
        }
    }
}
