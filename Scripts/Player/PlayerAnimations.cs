using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlayerMovement(Vector2 value)
    {
       
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
