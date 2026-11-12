using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealthScript : MonoBehaviour
{
    public int playerHitPoints = 0;

    //hi nik sorry making ur int public so i can access it in the EndGameController :P -AD
    //also perchance delete this and write a full comment on this script for points >:D -AD

    //also adding temp health display so i can test it -AD

    public TextMeshProUGUI healthDisplay;

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

        //health check:
        healthDisplay.text = playerHitPoints.ToString();
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

    public void TakeDamage(int damage)
    {
        //ADD IFRAME LOGIC
        playerHitPoints -= damage;
        //made it public so enemy collision script can access it 
    }
}
