using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameController : MonoBehaviour
{
    /// <summary>
    /// This script will be in scene but called from other things throughout the scene to either quit the game and operate win screen/lose screen buttons
    /// </summary>
    
    public ShipDeposit sd;
    [SerializeField] private string nextScene;
    [SerializeField] private GameObject winScreen;

    void Update()
    {
        if (sd.allPiecesCollected) //when you win
        {
            winScreen.SetActive(true);
            Time.timeScale = 0.0f;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //to quit the game whenever
        if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.Tab)))
        {
            Application.Quit();
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextScene);
        Debug.Log("Load next scene button pressed");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit game button pressed");
    }
}
