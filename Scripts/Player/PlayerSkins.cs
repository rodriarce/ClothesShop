
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Script to store the skins data list and reference in the player
public class PlayerSkins : MonoBehaviour
{
    public List<SkinsData> playerSkins;
    public SpriteRenderer hood;
    public SpriteRenderer leftShoulder;
    public SpriteRenderer rightShoulder;
    public SpriteRenderer leftWrist;
    public SpriteRenderer rightWrist;
    public SpriteRenderer torso;
    public SpriteRenderer leftBoot;
    public SpriteRenderer rightBoot;
    public SpriteRenderer leftLeg;
    public SpriteRenderer rightLeg;
    public SpriteRenderer pelvis;
    public SpriteRenderer leftElbow;
    public SpriteRenderer rightElbow;



    // Start is called before the first frame update
    void Start()
    {
        playerSkins = Resources.LoadAll<SkinsData>("Skins/").ToList();
    }

    public void OnChangeSkin(string nameSkin)
    {
        // Method to change the skin in the player
        var skin = GetPlayerSkin(nameSkin);
        hood.sprite = skin.hood;
        leftShoulder.sprite = skin.leftShoulder;
        rightShoulder.sprite = skin.rightShoulder;
        leftWrist.sprite = skin.leftWrist;
        rightWrist.sprite= skin.rightWrist;
        torso.sprite = skin.torso;
        leftBoot.sprite = skin.leftBoot;
        rightBoot.sprite = skin.rightBoot;
        leftLeg.sprite = skin.leftLeg;
        rightLeg.sprite = skin.rightLeg;
        pelvis.sprite = skin.pelvis;   
        leftElbow.sprite = skin.leftElbow;
        rightElbow.sprite = skin.rightElbow;    


    }
    private SkinsData GetPlayerSkin(string skinName)
    {
        foreach (var skin in playerSkins)
        {
            if (skin.itemName.Equals(skinName))
            {
                return skin;
            }
        }
        return null;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
