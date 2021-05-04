using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public GameObject[] CopyObject;
    public GameObject InsObj;
    public Transform Position;
    private bool isObjCreated;
    void Start ()
    {
        isObjCreated = false;
    }
    void OnTriggerEnter(Collider Player)
    {
        if (!isObjCreated)
        {
            InsObj = Instantiate(CopyObject[0]);
            InsObj.transform.position = Position.transform.position;
            InsObj.SetActive(true);
            isObjCreated = true;
        }
    }
    
}
