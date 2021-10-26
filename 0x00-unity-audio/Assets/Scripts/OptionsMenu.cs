using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] AudioMixer SFXMixer; 
    [SerializeField] Slider BGMSlider;
    [SerializeField] Slider SFXSlider;

    void Start()
    {
        if(!PlayerPrefs.HasKey("BGMVolume"))
        {
            PlayerPrefs.SetFloat("BGMVolume", 1);
            LoadVol();
        }
        else if (!PlayerPrefs.HasKey("SFXVolume"))
        {
            PlayerPrefs.SetFloat("SFXVolume", 1);
            LoadVol();
        }
        else
            LoadVol();


    }
    
    public void Back()
    {
        int scene = PlayerPrefs.GetInt("PrevScene");
        SceneManager.LoadScene(scene);
    }

    public void ChangeVolume()
    {
        AudioListener.volume = BGMSlider.value;
        SaveVol();

    }
    public void LoadVol()
    {
        BGMSlider.value = PlayerPrefs.GetFloat("BGMVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }
    public void SaveVol()
    {
        PlayerPrefs.SetFloat("BGMVolume", BGMSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }

    public void SetSFX(float SFX)
    {
        SFXMixer.SetFloat("SFXMVolume", Mathf.Log10(SFX) * 20);
        SaveVol();
    }




}
