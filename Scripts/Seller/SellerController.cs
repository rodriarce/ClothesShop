
using UnityEngine;

// Script to handle the sell Interaction with the player

public class SellerController : MonoBehaviour, ISellItems
{
      
    public PlayerDependencies playerDependencies { get; set; }




    public void OnEndSell(ItemData itemData)
    {      
        // Method when the sell ends to check if the player can buy the item
        if (playerDependencies.playerStats.OnPurchasedItem(itemData.price))
        {

            if (itemData.kindOfItem == KindOfItem.Skin)
            {
                playerDependencies.uiManager.OnEquipItem = () => playerDependencies.playerSkins.OnChangeSkin(itemData.itemName);
                playerDependencies.uiManager.ShowPanelEquipItem();
               

            }
            else
            {
                playerDependencies.uiManager.ShowPanelInfo("Succes Buying Item!");
            }

            playerDependencies.audioManager.OnConfirmButton();

        }
        else
        {
            playerDependencies.uiManager.ShowPanelInfo("Not Enough Coins");
            playerDependencies.audioManager.OnCancelButton();
        }

      
       
    }

    

   

    public void OnSellItems()
    {
        // Method when the player trigger with the seller
        playerDependencies.uiManager.isInMenu = true;
        playerDependencies.uiManager.ShowShopPanel();
    }

    // Start is called before the first frame update
    void Start()
    {
       playerDependencies = FindObjectOfType<PlayerDependencies>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
