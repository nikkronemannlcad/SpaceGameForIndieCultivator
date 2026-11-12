using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToLevel : MonoBehaviour
{
    private bool playerInRange;
    [SerializeField] private string levelToGoTo;

    public void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Interact()
    {
        SceneManager.LoadScene(levelToGoTo);
        Debug.Log("Player has moved onto the " + levelToGoTo +" Level");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player Is In " + levelToGoTo + " Portal Range");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            Debug.Log("Player Left" + levelToGoTo + " Portal Range");
        }
    }
}
