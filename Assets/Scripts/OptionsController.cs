using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider difficultySlider;

    [SerializeField] Slider volumeSlider;
    MusicPlayer musicPlayer;
    float defaultVolume = 0.8f;
    float defaultDifficulty = 0f;


    void Start()
    {
        musicPlayer = FindObjectOfType<MusicPlayer>();
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
        difficultySlider.value = PlayerPrefsController.GetDifficulty();

    }

    public void UpdateVolume()
    {
        musicPlayer.SetVolume(volumeSlider.value);
        Debug.Log("volume is " + volumeSlider.value);
    }

    public void UpdateDifficulty()
    {
       // musicPlayer.SetVolume(volumeSlider.value);
        //Debug.Log("volume is " + volumeSlider.value);
    }

    public void SetDefault()
    {
        volumeSlider.value = defaultVolume;
        difficultySlider.value = defaultDifficulty;
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetDiffuiculty(difficultySlider.value);

        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

}
