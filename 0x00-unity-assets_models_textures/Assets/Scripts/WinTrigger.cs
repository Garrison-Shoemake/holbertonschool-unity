using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text timesUp;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            timesUp.fontSize = 60;
            timesUp.color = Color.green;
            player.GetComponent<Timer>().enabled = false;
        }
    }
}
