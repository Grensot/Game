using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Close : MonoBehaviour
{
    public GameObject Player;
    private DoorAnimator Door;
    private float distance;
    public float interdist = 2f;
    public KeyCode Open_close = KeyCode.E;


    void OnMouseOver()
    {
        distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
        if (distance < interdist)
        {
            Debug.Log("Все норм");
            if (Input.GetKeyDown(Open_close))
            {
                Door.PlayAnimation();
            }
        }
    }
}
