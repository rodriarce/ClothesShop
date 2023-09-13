using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISellItems 
{
    public void OnSellItems();
    public void OnEndSell(ItemData itemData);
    
    public PlayerDependencies playerDependencies { get; set; }


   


}
