using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour
{
    /// <summary>
    /// This script will be in scene but called from other things throughout the scene to either quit the game and operate win screen/lose screen buttons
    /// </summary>
    
    public ShipDeposit sd;
    public PlayerHealthScript phs;
    [SerializeField] private string thisScene;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject loseScreen;

    void Update()
    {
        if (sd.allPiecesCollected) //when you win
        {
            winScreen.SetActive(true);
            Time.timeScale = 0.0f;
        }

        if (phs.playerHitPoints <= 0) //when you lose
        {
            loseScreen.SetActive(true);
            Time.timeScale = 0.0f;
        }

        //to quit the game whenever
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.Tab)))
        {
            Application.Quit();
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
