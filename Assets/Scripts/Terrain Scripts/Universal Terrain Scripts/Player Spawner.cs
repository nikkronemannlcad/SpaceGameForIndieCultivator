using Unity.VisualScripting;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{

    [SerializeField] private GameObject playerPref;
    [SerializeField] private GameObject cameraPref;

    //Attach this to an Empty and Just use the Empties location to set spawn points for the new levels pls Kaela
    //The Camera might be a little bit messed up because of this but ima try and fix it.
    [SerializeField] private Transform spawnlocation;

    void Start()
    {
        if (playerPref == null && cameraPref == null && spawnlocation == null)
        {
            Debug.Log("Nik Please Go Check yoru inspector again");
            return;
        }

        GameObject Player = Instantiate(playerPref, spawnlocation.position, playerPref.transform.rotation);

        GameObject Camera = Instantiate(cameraPref, spawnlocation.position, cameraPref.transform.rotation);
    }
}
