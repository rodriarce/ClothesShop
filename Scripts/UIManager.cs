using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject shopPanel;

    public GameObject panelTextInfo;
    public TextMeshProUGUI textInfo;
    public Button closeInfoPanel;   
    public bool isInMenu;
    public TextMeshProUGUI textCoins;
    public Button closeShopPanel;
   


    // Start is called before the first frame update
    void Start()
    {
        
        closeInfoPanel.onClick.AddListener(() => HidePanelInfo());
        closeShopPanel.onClick.AddListener(() => HideShopPanel());
    }


    public void OnSetCoinsValue(float amount)
    {
        textCoins.text = amount.ToString();
    }


    public void HidePanelInfo()
    {
        isInMenu = false;
    }


    public void ShowPanelInfo(string text)
    {
        isInMenu = true;
        textInfo.text = text;
        panelTextInfo.SetActive(true);
    }

    public void ShowShopPanel()
    {
        isInMenu = true;
        shopPanel.gameObject.SetActive(true);
    }
    public void HideShopPanel()
    {
        isInMenu = false;
        shopPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
