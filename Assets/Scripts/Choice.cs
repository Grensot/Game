using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice : MonoBehaviour
{
    public GameObject[] ChoiceButtons, another;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ChoiceButtons[0].SetActive(true);
            ChoiceButtons[1].SetActive(true);
        }
    }
    public void Finish()
    {
        Debug.Log("1");
        another[0].SetActive(true);
        another[1].SetActive(false);
        ChoiceButtons[0].SetActive(false);
        ChoiceButtons[1].SetActive(false);
    }
    public void Spare()
    {
        Debug.Log("2");
        another[0].SetActive(true);
        another[1].SetActive(false);
        ChoiceButtons[0].SetActive(false);
        ChoiceButtons[1].SetActive(false);
    }
}
