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
        ObjectCreated = false;
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        if (playerInSightRange) ChasePlayer();
        if (agent.remainingDistance <= 10.0f)
        {
            if (Enemy.GetComponent<WaypointPatrol>() != null)
            {
                Enemy.GetComponent<WaypointPatrol>().enabled = true;
            }
            Destroy(InsObj);
            ObjectCreated = false;
        }
    }
    private void ChasePlayer()
    {
        if(Enemy.GetComponent<WaypointPatrol>() != null)
        {    
            Enemy.GetComponent<WaypointPatrol>().enabled = false;
        }
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
}