using UnityEngine;

public class UIManager : MonoBehaviour
{
    /// <summary>
    /// WILL PROBABLY BE AMENDED INTO A GAME MANAGER!!
    /// For now, the UI manager is for displaying if a ship part has been collected and checks against the item pickup script to display the correct UI image
    /// </summary>
     
    public ItemPickup ip;
    [SerializeField] private GameObject sp1Inventory;
    void Update()
    {
        if (ip.shipPartsCollected == 1)
        {
            sp1Inventory.SetActive(true);
        }

        //this if statement will be duped per item collected 
        //however! i want to talk to everyone more about this but the items would each have a specific UI sprite so it makes sense to attach them to a specific variable each
        //but if we collect all of the items in order then use them, we can probably switch it to an integer that is added to per item collect as we go throuhg the levels chronologically!
        //for now the display is attached to a bool we will probably edit this though!
    }
}
