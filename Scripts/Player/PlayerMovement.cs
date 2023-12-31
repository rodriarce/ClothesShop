using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;


// Script to handle the inputs and the player movements and detects the triggers
public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset inputActionAsset;
    public InputActionProperty inputMovePlayer;
    public float speedPlayer;
    private Vector2 inputValue;
    public GameObject playerAvatar;
    public bool isInWall;
    private Vector2 lastPositon;
    public UnityEvent<Vector2> onMovePlayer;
    public LayerMask playerLayer;
    public Transform pivot;   
    private PlayerDependencies playerDependencies;

    // Start is called before the first frame update

    private void Awake()
    {
        inputActionAsset.Enable(); 

    }

    void Start()
    {
       playerDependencies = GetComponent<PlayerDependencies>();
       
       
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {

        if (playerDependencies.uiManager.isInMenu)
        {
            onMovePlayer.Invoke(Vector2.zero);
            return;
        }

        // Read the input value 

        inputValue = inputMovePlayer.action.ReadValue<Vector2>();




        Vector3 translation = inputValue * speedPlayer * Time.fixedDeltaTime;
       

     
       // Raycast to check walls 
        RaycastHit2D hit = Physics2D.Raycast(pivot.transform.position, inputValue, 2f, playerLayer);





        if (inputValue.x > 0)
        {
            playerAvatar.transform.rotation = Quaternion.identity;
        }
        else if (inputValue.x < 0)
        {
            playerAvatar.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        lastPositon = inputValue;
        onMovePlayer.Invoke(inputValue);
       
        if (hit.collider == null)
        {
            transform.Translate(translation);
       
        }  
      



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Seller"))
        {

            collision.GetComponent<ISellItems>().OnSellItems();

        }
        if (collision.gameObject.CompareTag("NPC"))
        {

            collision.GetComponent<InpController>().OnEnterNpc();

        }


    }




}
