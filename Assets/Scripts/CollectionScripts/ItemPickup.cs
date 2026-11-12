using UnityEngine;

public class ItemPickup : MonoBehaviour
{   
    /// <summary>
    /// This script controls item visibility when a player collects an ship parts throughout the level
    /// This collection bool will be used by UI to trigger when that item should show up in their inventory
    /// </summary> 
    
    public int shipPartsCollected;
    [SerializeField] private GameObject thisShipPart;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("got the item");
            shipPartsCollected++;
            //will probably put this variable in a game manager object bc 
            //for now, it lives within item pickup 
            thisShipPart.SetActive(false);
        }
    }
}
