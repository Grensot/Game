using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] lever;
    private Animator leverAnim;
    private float distance;
    public float interdist = 2f;
    public KeyCode UpDown = KeyCode.E;
    public bool LeverUp = false;
    public bool wrongLever;
    void OnMouseOver()
    {
        distance = Vector3.Distance(Player.GetComponent<Transform>().position, transform.position);
        if (distance < interdist)
        {

            if (Input.GetKeyDown(UpDown))
            {
                if (wrongLever)
                {
                    leverAnim = lever[0].GetComponent<Animator>();
                    leverAnim.Play("LeverDown", 0, 0.0f);
                    lever[0].GetComponent<Lever>().LeverUp = false;
                    leverAnim = lever[1].GetComponent<Animator>();
                    leverAnim.Play("LeverDown", 0, 0.0f);
                    lever[1].GetComponent<Lever>().LeverUp = false;
                    leverAnim = lever[2].GetComponent<Animator>();
                    leverAnim.Play("LeverDown", 0, 0.0f);
                    lever[2].GetComponent<Lever>().LeverUp = false;
                }
                else
                {
                    if (!LeverUp)
                    {
                        leverAnim = lever[0].GetComponent<Animator>();
                        leverAnim.Play("LeverUp", 0, 0.0f);
                        LeverUp = true;
                    }
                    else
                    {
                        leverAnim = lever[0].GetComponent<Animator>();
                        leverAnim.Play("LeverDown", 0, 0.0f);
                        LeverUp = false;
                    }
                }
            }
        }
    }
}
