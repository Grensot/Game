using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close : MonoBehaviour
{
    public GameObject Player;
    public GameObject Door;
    private Animator doorAnim;
    private float distance;
    public float interdist = 2f;
    public KeyCode Open_close = KeyCode.E;
    private bool doorOpen = false;
    private void Awake()
    {
        doorAnim = Door.GetComponent<Animator>();
    }
    void OnMouseOver()
    {
        distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
        if (distance < interdist)
        {

            if (Input.GetKeyDown(Open_close))
            {

                if (!doorOpen)
                {
                    doorAnim.Play("DoorO", 0, 0.0f);
                    doorOpen = true;
                }
                else
                {
                    doorAnim.Play("DoorC", 0, 0.0f);
                    doorOpen = false;
                }
            }
        }
    }
}
