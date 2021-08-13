using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAttack : MonoBehaviour
{
    public GameObject Player;
    public float speed = 10.0f;
    private float currentTime;


    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        currentTime += Time.deltaTime;
        if (currentTime <= 5)
        {
            transform.LookAt(Player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        }
        else
        {
            transform.position += Vector3.forward * step;
        }

    }
}   