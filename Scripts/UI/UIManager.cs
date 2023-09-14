using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;

// Script To handle the UI 

public class UIManager : MonoBehaviour 
{
    public GameObject shopPanel;
    public GameObject panelTextInfo;
    public TextMeshProUGUI textInfo;
    public Button closeInfoPanel;   
    public bool isInMenu;
    public TextMeshProUGUI textCoins;
    public Button closeShopPanel;
    public GameObject panelEquipSkin;
    public Action OnEquipItem;
    public Button buttonEquipItem;
    public Button buttonCloseEquipItem;
    public GameObject background;
    public AudioManager audioManager;
    
   


    // Start is called before the first frame update
    void Start()
    {
        
        closeInfoPanel.onClick.AddListener(() => HidePanelInfo());
        closeShopPanel.onClick.AddListener(() => HideShopPanel());
        buttonEquipItem.onClick.AddListener(() => OnEquipButton());
        buttonCloseEquipItem.onClick.AddListener(() => OnClosePanelEquipButton());
        audioManager = FindObjectOfType<AudioManager>();
    }


    public void OnSetCoinsValue(float amount)
    {
        textCoins.text = amount.ToString();
    }

    public void ShowPanelEquipItem()
    {
        audioManager.OnConfirmButton();
        background.SetActive(true);
        panelEquipSkin.SetActive(true);
        isInMenu = true;
        Cursor.visible = true;

    }

    public void OnEquipButton()
    {
        audioManager.OnConfirmButton();
        background.SetActive(false);
        OnEquipItem();
        panelEquipSkin.SetActive(false);
        isInMenu = false;
        Cursor.visible = false;
    }

    public void OnClosePanelEquipButton()
    {
        audioManager.OnCancelButton();
        background.SetActive(false);
        panelEquipSkin.SetActive(false);
        shopPanel.SetActive(false);
        isInMenu = false;
        Cursor.visible = false;
    }

    public void HidePanelEquip()
    {
        audioManager.OnCancelButton();
        background.SetActive(false);
        panelEquipSkin.SetActive(false);
        isInMenu = false;
        Cursor.visible = false;
    }



    public void HidePanelInfo()
    {
        audioManager.OnCancelButton();
        background.SetActive(false);
        isInMenu = false;
        Cursor.visible = false;
    }


    public void ShowPanelInfo(string text)
    {
        background.SetActive(true);
        isInMenu = true;
        textInfo.text = text;
        panelTextInfo.SetActive(true);
        Cursor.visible = true;
    }

    public void ShowShopPanel()
    {
        background.SetActive(true);
        isInMenu = true;
        shopPanel.gameObject.SetActive(true);
        Cursor.visible = true;
    }
    public void HideShopPanel()
    {
        background.SetActive(false);
        shopPanel.gameObject.SetActive(false);
        isInMenu = false;        
        Cursor.visible = false;
        audioManager.OnCancelButton();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
