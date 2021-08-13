using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public GameObject Invincibility;
    private bool buffed;
    private double stoptime;
    [SerializeField] private float newSpeed;
    [SerializeField] private int currentTime, presedbuttons;
    [SerializeField] private Movement movement;

    void FixedUpdate()
    {
        if (Time.time > currentTime)
        {
            currentTime++;
        }
        if (stoptime < currentTime)
        {
            newSpeed = 10;
            movement.SetSpeed(newSpeed);
            buffed = false;
        }
        if(presedbuttons == 2)
        {
            Invincibility.SetActive(true);
        }

    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "boost")
        {
            BuffTime();
            collisionInfo.gameObject.SetActive(false);
        }
        if (collisionInfo.gameObject.tag == "button")
        {
            presedbuttons++;
            collisionInfo.gameObject.SetActive(false);
        }
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "deboost")
        {
            DeBuffTime();
        }
    }
    void BuffTime()
    {
        buffed = true;
        stoptime = currentTime + 10;
        newSpeed += 5;
        movement.SetSpeed(newSpeed);
    }
    void DeBuffTime()
    {
        if (!buffed)
        {
            stoptime = currentTime + 0.1;
            newSpeed = 5;
        }
        else
        {
            newSpeed = 10;
        }

        movement.SetSpeed(newSpeed);
    }
}
