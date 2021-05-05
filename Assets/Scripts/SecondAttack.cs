using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondAttack : MonoBehaviour
{
    public GameObject Player;
    public int currentTime;
    public GameObject[] CopyObject;
    private GameObject InsObj;
    private bool Created;

    void FixedUpdate()
    {
        if (Time.time > currentTime)
        {

            currentTime++;
        }
        if (currentTime <= 10)
        {
            transform.LookAt(Player.transform.position);
            if (currentTime % 2 == 0)
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
}
