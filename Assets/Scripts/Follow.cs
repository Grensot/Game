using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent enemy;
    public Transform Object;
    public Transform Tele2;
    void FixedUpdate()
    {
        enemy.SetDestination(Object.position);
    }
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            Object.transform.position = Tele2.position;
            Destroy(gameObject);
        }
    }
}
