using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject costil, _target;

    private float Ver, Hor, Jump;

    public bool isGround;

    public float Speed = 10, JumpSpeed = 200, MovementSpeed, Direction;

    public Animator _animator;

    void FixedUpdate()
    {
        _animator.SetFloat("Speed", MovementSpeed);
        _animator.SetFloat("Direction", Direction);

        transform.rotation = costil.transform.rotation;

        if(isGround)
        {
            Ver = Input.GetAxis("Vertical") * Time.deltaTime * Speed;
            Hor = Input.GetAxis("Horizontal") * Time.deltaTime * Speed;
            Jump = Input.GetAxis("Jump") * Time.deltaTime * JumpSpeed;
            GetComponent<Rigidbody>().AddForce(transform.up * Jump, ForceMode.Impulse);
        }
        transform.Translate(new Vector3(Hor, 0, Ver));
        if(Input.GetKeyDown(KeyCode.A) && Direction < 1)
        {
            Direction += 0.5f;
        }
        if (Input.GetKeyDown (KeyCode.D) && Direction > -1)
        {
            Direction -= 0.5f;
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            MovementSpeed = 1;
        }

    }
    protected void OnAnimatorIK(int layerIndex)
    {
        _animator.SetLookAtPosition(_target.transform.position);
        _animator.SetLookAtWeight(1);
    }
}
