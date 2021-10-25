using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start()
    {
        PlayerPrefs.GetFloat("MusicVolume", 1f);
    }
    public void LevelSelect(int level)
    {
        if (level == 5)
        {
            Debug.Log("Exited");
            return;
        }
        PlayerPrefs.SetInt("PrevScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(level);
    }
}
