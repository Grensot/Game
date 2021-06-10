using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceObj : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] CopyObject;
    private GameObject InsObj;
    private bool Created;
    public MainTimer MainTimer;

    void FixedUpdate()
    {
    transform.LookAt(Player.transform.position);
    if (MainTimer.currentTime % 2 == 0)
    {
        if (!Created)
        {
        InsObj = Instantiate(CopyObject[0], CopyObject[0].transform.position, CopyObject[0].transform.rotation);
        InsObj.transform.parent = null;
        InsObj.SetActive(true);

        Created = true;
        }
        }
        else
        {
        Created = false;
        }
    }
}
