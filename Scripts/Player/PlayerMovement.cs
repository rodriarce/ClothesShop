using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;



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
    public PlayerEquipment playerEquipment;

    // Start is called before the first frame update

    private void Awake()
    {
        inputActionAsset.Enable();
    }

    void Start()
    {
        
    }

   

    // Update is called once per frame
    void FixedUpdate()
    {

        if (playerEquipment.isInMenu)
        {
            return;
        }


        inputValue = inputMovePlayer.action.ReadValue<Vector2>();




        Vector3 translation = inputValue * speedPlayer * Time.fixedDeltaTime;
       

        //GetComponent<Rigidbody2D>().velocity = translation;
       
        RaycastHit2D hit = Physics2D.Raycast(pivot.transform.position, inputValue, 0.5f, playerLayer);





        if (inputValue.x == 1)
        {
            playerAvatar.transform.rotation = Quaternion.identity;
        }
        else if (inputValue.x == -1)
        {
            playerAvatar.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        lastPositon = inputValue;
        onMovePlayer.Invoke(inputValue);
       
        if (hit.collider != null)
        {
            //if (hit.collider.transform.CompareTag("Wall") || hit.collider.transform.CompareTag("Seller"))
            //{
            //    Debug.Log("You Hit A Wall");
            //    Debug.DrawRay(transform.position, hit.transform.position, Color.red);
            //    Debug.Log(hit.transform.name);

            //}
            //else
            //{
            //    transform.Translate(translation);
            //}
        }
        else
        {
            transform.Translate(translation);
        }
     
        //else
        //{
        //   
        //}



    }
   
  


}
