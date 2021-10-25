using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject winCanvas;
    public Text timesUp;
    public Text winText;
    public AudioSource winning;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            timesUp.fontSize = 60;
            timesUp.color = Color.green;
            player.GetComponent<Timer>().enabled = false;
            Win();
        }
    }
    void Win()
    {
        winning.Play();
        winText = timesUp;
        winCanvas.SetActive(true);
    }
}
