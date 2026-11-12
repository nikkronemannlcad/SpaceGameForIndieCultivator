using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    /// <summary>
    /// This script will be on the player and control when they die!
    /// </summary>
    public PlayerHealthScript phs;
    [SerializeField] private string thisScene;
    [SerializeField] private GameObject loseScreen;

    void Update()
    {
        if (phs.playerHitPoints <= 0) //when you lose
        {
            Debug.Log("playerlost");
            loseScreen.SetActive(true);
            Time.timeScale = 0.0f;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(thisScene);
        Debug.Log("buttonpressed");
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("buttonpressed");
    }
}
