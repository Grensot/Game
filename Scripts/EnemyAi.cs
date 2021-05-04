using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] CopyObject;
    private GameObject InsObj;
    public GameObject Enemy;
    private Transform Point;
    public Transform player;
    private bool ObjectCreated;



    public LayerMask whatIsGround, whatIsPlayer;

    public float sightRange;
    public bool playerInSightRange;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        ObjectCreated = false;
    }

    private void Update()
    {

        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        if (playerInSightRange) ChasePlayer();
    }
    private void ChasePlayer()
    {
        Enemy.GetComponent<WaypointPatrol>().enabled = false;
        if (!ObjectCreated)
        {
            ObjectCreated = true;
            InsObj = Instantiate(CopyObject[0]);
            InsObj.transform.position = player.position;
            InsObj.SetActive(true);
            Point = InsObj.GetComponent<Transform>();
        }
        agent.SetDestination(Point.position);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider == InsObj)
        {
            Enemy.GetComponent<WaypointPatrol>().enabled = true;
            Destroy(InsObj);
            ObjectCreated = false;
        }
    }
}