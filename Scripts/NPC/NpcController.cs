using System.Collections;
using UnityEngine;


// Simple script for a possible npc in the game
public class NpcController : MonoBehaviour, InpController
{
    public UIManager UIManager { get; set; }

   
    public string TextToShow { get; set; }
    public string textToShow;

    public void OnEnterNpc()
    {
        UIManager.ShowPanelInfo(TextToShow);
    }

    private void Start()
    {
        UIManager = FindObjectOfType<UIManager>();
        TextToShow = textToShow;
    }
  
}
