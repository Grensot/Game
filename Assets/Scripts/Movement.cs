using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject cam;

    private Quaternion StartingRotation;

    float Ver, Hor, Jump, RotHor, RotVer;

    public bool isGround;

    public float Speed = 10, JumpSpeed = 200, sensitivity = 5;


    void Start()
    {
        StartingRotation = transform.rotation;
        Cursor.lockState = CursorLockMode.Locked;
    }



    void FixedUpdate()
    {
        RotHor += Input.GetAxis("Mouse X") * sensitivity;
        RotVer += Input.GetAxis("Mouse Y") * sensitivity;

        RotVer = Mathf.Clamp(RotVer, -60, 60);

        Quaternion RotY = Quaternion.AngleAxis(RotHor, Vector3.up);
        Quaternion RotX = Quaternion.AngleAxis(-RotVer, Vector3.right);

        cam.transform.rotation = StartingRotation * transform.rotation * RotX;
        transform.rotation = StartingRotation * RotY;

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
