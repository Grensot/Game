using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTimer : MonoBehaviour
{
    public int Maintimer, currentTime;
    public GameObject[] objects;


    void Start()
    {
        Maintimer = 0;
        objects[0].SetActive(true);
        objects[1].SetActive(false);
    }

    void FixedUpdate()
    {
        if(Time.time > currentTime)
        {
            currentTime++;
        }
        if(currentTime >= 60 && currentTime <= 120)
        {
            objects[0].SetActive(false);
            objects[1].SetActive(true);
        }
        if (currentTime >= 120 && currentTime <= 180)
        {
            objects[0].SetActive(true);
            objects[1].SetActive(true);
        }
        if (currentTime >= 180)
        {
            objects[0].SetActive(false);
            objects[1].SetActive(false);
            objects[2].SetActive(true);
        }
    }
}
