using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject costil;

    float Ver, Hor, Jump;

    public bool isGround;

    public float Speed = 10, JumpSpeed = 200;


    void FixedUpdate()
    {

        transform.rotation = costil.transform.rotation;

        if(isGround)
        {
            Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
            Hor = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
            Jump = Input.GetAxis("Jump") * Time.deltaTime * JumpSpeed;
            GetComponent<Rigidbody>().AddForce(transform.up * Jump, ForceMode.Impulse);
        }
        transform.Translate(new Vector3(Hor, 0, Ver));
    }
}
