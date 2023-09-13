using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDependencies : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerEquipment playerEquipment;
    public PlayerStats playerStats;
    public UIManager uiManager;
    public PlayerSkins playerSkins;
      

    // Start is called before the first frame update


    private void Awake()
    {
       playerMovement = GetComponent<PlayerMovement>();
        playerEquipment = GetComponent<PlayerEquipment>(); 
        playerStats = GetComponent<PlayerStats>();
        uiManager = FindObjectOfType<UIManager>();
        playerSkins = GetComponent<PlayerSkins>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
