using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    [SerializeField] private int playerHitPoints = 0;

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
