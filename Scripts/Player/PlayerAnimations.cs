using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script  to control the player animations in the movements

public class PlayerAnimations : MonoBehaviour
{
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlayerMovement(Vector2 value)
    {
       // Set the animations when the player is walking
        if (value != Vector2.zero)
        {
            playerAnimator.SetBool("isWalk", true);
        }
        else
        {
            playerAnimator.SetBool("isWalk", false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
