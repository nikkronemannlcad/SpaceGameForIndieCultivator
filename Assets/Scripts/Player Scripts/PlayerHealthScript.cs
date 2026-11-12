using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public int playerHitPoints = 0;

    //hi nik sorry making ur int public so i can access it in the EndGameController :P
    //also perchance delete this and write a full comment on this script for points >:D

    private GameObject spawnpoint;
    private void Start()
    {
        playerHitPoints = 3;
        spawnpoint = GameObject.FindGameObjectWithTag("SpawnPoint");
    }
    private void Update()
    {
        if (playerHitPoints <= 0)
        {
            Respawn();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }

    private void Respawn()
    {
        //ADD LOGIC
    }

    private void TakeDamage(int damage)
    {
        //ADD IFRAME LOGIC
        playerHitPoints -= damage;
    }
}
