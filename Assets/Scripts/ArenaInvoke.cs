using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaInvoke : MonoBehaviour
{
    public float currentTime;
    public GameObject[] CopyObject;
    public GameObject InsObj;
    public Transform Position;



    void Start()
    {
        
    }


    void FixedUpdate()
    {
        currentTime += Time.deltaTime;
        if(currentTime == 5)
        {
            InsObj = Instantiate(CopyObject[0]);
            InsObj.transform.position = Position.transform.position;
            InsObj.SetActive(true);
        }
    }
}
