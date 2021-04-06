using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAttack : MonoBehaviour
{
    public GameObject Player;
    public float speed = 10.0f;
    private float currentTime;
    private Rigidbody InsObj;
    public Rigidbody[] CopyObject;

    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        currentTime += Time.deltaTime;
        if(currentTime <= 10)
        {
            transform.LookAt(Player.transform.position);
            if (currentTime % 2 == 0)
            {
                InsObj = Instantiate(CopyObject[0], transform.position, transform.rotation);
            }
        }
        InsObj.velocity = transform.TransformDirection(Vector3.down * 10);
    }
}
