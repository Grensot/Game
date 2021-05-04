using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    public GameObject Bullet;
    public float speed = 10.0f;
    public Rigidbody Rb;

    void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        Rb.velocity = transform.TransformDirection(Vector3.down * step);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ground")
        {
            Destroy(Bullet);
        }
    }

}
