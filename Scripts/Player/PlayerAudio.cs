using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script in player to control the player sounds like walk
public class PlayerAudio : MonoBehaviour
{
    public PlayerDependencies playerDependencies;

    // Start is called before the first frame update
    void Start()
    {
        playerDependencies = GetComponent<PlayerDependencies>();
    }

    public void OnPlayerMove(Vector2 value)
    {
        if (value == Vector2.zero)
        {
            playerDependencies.audioManager.OnPlayerStop();
        }
        else
        {
            playerDependencies.audioManager.OnPlayerWalk();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
