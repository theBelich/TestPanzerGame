using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        EnemyStats enemyStats = GetComponent<EnemyStats>();
        agent = GetComponent<NavMeshAgent>();
        playerPos = GameObject.FindWithTag("Player").transform;
        agent.speed = enemyStats.moveSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = playerPos.position;
    }
}
