using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToHub : MonoBehaviour
{
    private bool playerInRange;

    public void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Interact()
    {
        //SceneManager.LoadScene("Hub"); Hub Not Added Yet
        Debug.Log("Player has moved onto the Hub Level");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player Is In Hub Portal Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player Left Hub Portal Range");
        }
    }
}
