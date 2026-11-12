using UnityEngine;

public class ShipDeposit : MonoBehaviour
{
    /// <summary>
    /// This script manages when a player can deposit ship parts and alters their inventory when it does
    /// It also adds a visual indicator on the ship that it is fixed
    /// It uses the collection bool from the last item pickup to trigger this
    /// </summary>
     
    
    //[SerializeField] private bool thisPartCollected;
    [SerializeField] private bool inShipZone;
    [SerializeField] private GameObject depositMessage;

    public ItemPickup ip;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && ip.shipPart1Collected)
        {
            Debug.Log("canDeposit");
            inShipZone = true;
            depositMessage.SetActive(true);
        } 
        else if (other.gameObject.CompareTag("Player"))
        {
            inShipZone = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        inShipZone = false;
        depositMessage.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && ip.shipPart1Collected && inShipZone)
        {
            Debug.Log("dropped the item");
        }
    }
}
