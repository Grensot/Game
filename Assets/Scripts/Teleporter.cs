using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject[] CopyObject;
    public GameObject Player;
    private GameObject InsObj;
    public Transform Position;
    private Rigidbody rb;
    public float throwForce;
    private bool isObjCreated;
    void Start()
    {
        isObjCreated = false;
    }
    void FixedUpdate()
    {
        if (!isObjCreated)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                InsObj = Instantiate(CopyObject[0]);
                InsObj.transform.position = Position.transform.position;
                InsObj.transform.rotation = Position.transform.rotation;
                InsObj.SetActive(true);
                
                InsObj.GetComponent<Rigidbody>().isKinematic = false;
                rb = InsObj.GetComponent<Rigidbody>();
                rb.AddForce(transform.forward * throwForce);
                InsObj.transform.parent = null;
            }
        }
    }
}
