using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Scriptable Object to store the sprites of the skins
[CreateAssetMenu(fileName = "Skin", menuName = "Items")]

public class SkinsData : ScriptableObject
{
    public string itemName;
    public Sprite hood;
    public Sprite leftShoulder;
    public Sprite rightShoulder;
    public Sprite leftWrist;
    public Sprite rightWrist;
    public Sprite torso;
    public Sprite leftBoot;
    public Sprite rightBoot;
    public Sprite leftLeg;
    public Sprite rightLeg;
    public Sprite pelvis;
    public Sprite leftElbow;
    public Sprite rightElbow;
    
  
}
