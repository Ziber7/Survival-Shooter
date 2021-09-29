using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    // Deklarasi Variabel 
    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        // look for game object dengan tag player
        player = GameObject.FindGameObjectWithTag("Player").transform;
 
        //Mendapatkan Reference component
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        //Memindahkan posisi player
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth> 0)
        {
           nav.SetDestination(player.position);
        }
        else // Stop Movement
        {
            nav.enabled = false;
        }
    }
}
