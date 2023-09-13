using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private float amountCoins;
    public UIManager uiManager;
    private PlayerDependencies playerDependencies;
    // Start is called before the first frame update
    void Start()
    {
        playerDependencies = GetComponent<PlayerDependencies>();        
        playerDependencies.uiManager.OnSetCoinsValue(amountCoins);

    }

    public bool OnPurchasedItem(float price)
    {
        if (amountCoins >= price)
        {
            amountCoins -= price;
            playerDependencies.uiManager.OnSetCoinsValue(amountCoins);
            return true;
        }
        else
        {
            return false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
