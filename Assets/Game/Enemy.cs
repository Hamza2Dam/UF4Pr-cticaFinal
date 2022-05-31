using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{

    public Transform Player;
    NavMeshAgent enemy;

    public float distancia = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if (distance < distancia)
        {
            //Seguir a el Jugador
            enemy.SetDestination(Player.position);
        }
    }
}