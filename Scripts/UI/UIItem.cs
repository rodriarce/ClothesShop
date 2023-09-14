using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIItem : MonoBehaviour
{
    public ItemData itemData;
    public Button buyButton;
    public TextMeshProUGUI textNameItem;
    public TextMeshProUGUI textPrice;
    public Image iconImage;
    private ISellItems sellerItems;
      // Start is called before the first frame update
    void Start()
    {
        SetItemData();
        sellerItems = GameObject.FindGameObjectWithTag("Seller").GetComponent<ISellItems>();
        buyButton.onClick.AddListener(OnBuyItem);
       
    }

    private void OnBuyItem()
    {
        sellerItems.OnEndSell(itemData);
     
    }


    private void SetItemData()
    {
        textNameItem.text = itemData.itemName;
        textPrice.text = itemData.price.ToString();
        iconImage.sprite = itemData.icon;

    }


}
