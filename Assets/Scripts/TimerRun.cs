using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerRun : MonoBehaviour
{
    public TMP_Text scoreTimer;
    public float timeStart;
    public TMP_Text textTimer;
    public bool timerRunning = false;

    void Update()
    {
        if(timerRunning==true)
        {
            timeStart += Time.deltaTime;
            float minutes = Mathf.FloorToInt(timeStart / 60);
            float seconds = Mathf.FloorToInt(timeStart % 60);
            float milliseconds = timeStart % 1 * 1000;
            textTimer.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
        }
    }
}
