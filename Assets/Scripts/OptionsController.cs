using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    MusicPlayer musicPlayer;
    float defaultVolume = 0.8f;

    void Start()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();

    }

     void Update()
    {
        musicPlayer.SetVolume(volumeSlider.value);
        Debug.Log("volume is " + volumeSlider.value);
    }

    public void SetDefault()
    {
        volumeSlider.value = defaultVolume;
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

}
