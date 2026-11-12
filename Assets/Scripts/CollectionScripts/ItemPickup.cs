using UnityEngine;

public class ItemPickup : MonoBehaviour
{   
    /// <summary>
    /// This script controls item visibility when a player collects an ship parts throughout the level
    /// This collection bool will be used by UI to trigger when that item should show up in their inventory
    /// </summary>
    /// 
    
    public bool shipPart1Collected;
    [SerializeField] private GameObject thisShipPart;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("got the item");
            shipPart1Collected = true;
            thisShipPart.SetActive(false);
        }
    }
}
