using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer BGM;
    public AudioMixer SFX;
    public Slider BGMSlider;

    void Start()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
    }
    public void Back()
    {
        int scene = PlayerPrefs.GetInt("PrevScene");
        SceneManager.LoadScene(scene);
    }

    public void SetLevel (float sliderValue)
    {
        BGM.SetFloat("BGMVolume", Mathf.Log10(sliderValue) * 20);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }

}
