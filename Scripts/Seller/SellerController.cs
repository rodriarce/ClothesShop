using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerController : MonoBehaviour, ISellItems
{
   
    public UIManager uiManager;
    public PlayerEquipment PlayerEquipment { get; set; }

    public void OnEndSell()
    {
        uiManager.HideShopPanel();
        PlayerEquipment.isInMenu = false;
    }

    public void OnSellItems()
    {

        uiManager.ShowShopPanel();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerEquipment = FindObjectOfType<PlayerEquipment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
