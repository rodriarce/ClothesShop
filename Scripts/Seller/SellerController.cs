using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerController : MonoBehaviour, ISellItems
{
      
    public PlayerDependencies playerDependencies { get; set; }




    public void OnEndSell(ItemData itemData)
    {


       


        if (playerDependencies.playerStats.OnPurchasedItem(itemData.price))
        {

            if (itemData.kindOfItem == KindOfItem.Skin)
            {
                playerDependencies.playerSkins.OnChangeSkin(itemData.itemName);
            }


            playerDependencies.uiManager.ShowPanelInfo("Succes Buy Item");
        }
        else
        {
            playerDependencies.uiManager.ShowPanelInfo("Not Enough Coins");
        }

      
       
    }

    

   

    public void OnSellItems()
    {
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
