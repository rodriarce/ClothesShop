using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interface about The interaction with the seller
public interface ISellItems 
{
    public void OnSellItems();
    public void OnEndSell(ItemData itemData);
    
    public PlayerDependencies playerDependencies { get; set; }


   


}
