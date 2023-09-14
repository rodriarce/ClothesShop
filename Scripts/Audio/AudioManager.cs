using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to control the audios of the game like buttons and background music
public class AudioManager : MonoBehaviour
{
    public AudioSource audioSteps;
    public AudioClip clipConfirmButton;
    public AudioClip clipCancelButton;
    public AudioClip clipWalk;
    public AudioClip clipSoundtrack;
    public AudioSource audioButtons;
    public AudioSource audioBackground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnPlayerWalk()
    {
        if (!audioSteps.isPlaying)
        {
            audioSteps.clip = clipWalk;
            audioSteps.loop = true;
            audioSteps.Play();
        }
        
    }

    public void OnConfirmButton()
    {
        audioButtons.clip = clipConfirmButton;
        audioButtons.Play();
    }
    public void OnCancelButton()
    {
        audioButtons.clip = clipCancelButton;
        audioButtons.Play();
    }

    public void OnPlayerStop()
    {
        audioSteps.Stop();
        audioSteps.clip = clipWalk;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
