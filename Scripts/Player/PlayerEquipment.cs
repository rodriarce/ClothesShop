using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipment : MonoBehaviour
{

    public List<SkinsData> playerSkins;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
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
