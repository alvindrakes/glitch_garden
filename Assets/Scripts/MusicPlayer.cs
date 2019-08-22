using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{

    AudioSource audioSource;
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(0.8f);
        DontDestroyOnLoad(this);
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsController.GetMasterVolume();
        Debug.Log("audiosource volume = " + audioSource.volume);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
   
}
