using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_Drop : MonoBehaviour
{
    public GameObject Player;
    private float distance;
    public float interdist = 2f;
    public Transform arm;
    public Rigidbody rb;
    public KeyCode TakeObject = KeyCode.E;
    public KeyCode RemoveObject = KeyCode.Q;
    public KeyCode ThrowObject = KeyCode.F;
    public float throwForce;

    void OnMouseOver()
    {
        distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
        if(distance < interdist)
        {
            if(Input.GetKeyDown (TakeObject))
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.position = arm.position;
                transform.rotation = arm.rotation;
                transform.SetParent(arm);
            }
        }
    }
    void Update ()
    {
        if (Input.GetKeyDown(RemoveObject))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.parent = null;
        }
        if (Input.GetKeyDown(ThrowObject))
        {
            GetComponent<Rigidbody>().isKinematic = false;
            rb.AddForce(transform.forward * throwForce);
            transform.parent = null;
            
        }
    }


}
