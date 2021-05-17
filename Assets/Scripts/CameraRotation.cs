using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public Transform[] pos;
    public Transform cam, LookAt;
    public float speed, timer, rotationSpeed;
    public KeyCode Right = KeyCode.RightArrow, Left = KeyCode.LeftArrow;
    public int posnumber;
    public float TimeRemaining, Timer;
    private bool Move = false;

    void Start()
    {
        cam.transform.position = pos[0].transform.position;
        posnumber = 0;
    }

    void FixedUpdate()
    {
        Timer += Time.deltaTime;
        if (Move)
        {
            if(TimeRemaining <= Timer)
            {
                cam.transform.position = pos[posnumber].transform.position;
                Move = false;
            }
        }
        if (Move)
        {
            transform.LookAt(LookAt);

        }
        if (cam.transform.position != pos[posnumber].position)
        {
           cam.transform.position += (pos[posnumber].transform.position - cam.transform.position).normalized * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(Right))
        {
            Move = true;
            TimeRemaining = Timer + timer;
            if (posnumber == 3)
            {
                posnumber = 0;
            }
            else
            {
                posnumber++;
            }
            
        }
        if (Input.GetKeyDown(Left))
        {
            Move = true;
            TimeRemaining = Timer + timer;
            if (posnumber == 0)
            {
                posnumber = 3;
            }
            else
            {
                posnumber--;
            }
            
        }
    }
}
