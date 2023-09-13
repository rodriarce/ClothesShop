using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject shopPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowShopPanel()
    {
        shopPanel.gameObject.SetActive(true);
    }
    public void HideShopPanel()
    {
        shopPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
