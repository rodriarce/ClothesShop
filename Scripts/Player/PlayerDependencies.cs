using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to handle the player dependencies
public class PlayerDependencies : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerStats playerStats;
    public UIManager uiManager;
    public PlayerSkins playerSkins;
    public AudioManager audioManager;
      

    // Start is called before the first frame update


    private void Awake()
    {
       playerMovement = GetComponent<PlayerMovement>();
        playerStats = GetComponent<PlayerStats>();
        uiManager = FindObjectOfType<UIManager>();
        playerSkins = GetComponent<PlayerSkins>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
