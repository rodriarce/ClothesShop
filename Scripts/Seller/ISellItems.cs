using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISellItems 
{
    public void OnSellItems();
    public void OnEndSell();
    public PlayerEquipment PlayerEquipment { get; set; }

   


}
