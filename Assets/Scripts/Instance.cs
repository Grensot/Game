using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour
{
    public GameObject[] CopyObject;
    public GameObject InsObj;
    bool isObjCreated;
    void Start ()
    {
        isObjCreated = false;
    }
    void OnTriggerEnter(Collider Player)
    {
        if (!isObjCreated)
        {
            InsObj = Instantiate(CopyObject[0]);
            InsObj.transform.position = new Vector3(20, 4, 4);
            InsObj.SetActive(true);
            isObjCreated = true;
        }
    }
    
}
