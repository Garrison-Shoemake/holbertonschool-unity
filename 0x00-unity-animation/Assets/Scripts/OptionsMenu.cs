using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public void Back()
    {
        int scene = PlayerPrefs.GetInt("PrevScene");
        SceneManager.LoadScene(scene);
    }
}
