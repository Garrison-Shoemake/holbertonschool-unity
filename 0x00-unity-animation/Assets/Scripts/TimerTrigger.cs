using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Timer>().enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        player.GetComponent<Timer>().enabled = true;
    }
}
