using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum KindOfItem
{
    Item,
    Skin
} 




[CreateAssetMenu(fileName = "Item", menuName = "Items")]

public class ItemData : ScriptableObject
{
    public string itemName;
    public float price;
    public Sprite icon;
    public KindOfItem kindOfItem;
    
}
