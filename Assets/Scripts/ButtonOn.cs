using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOn : MonoBehaviour
{
    public bool testRunning=false;
    public TimerRun finishTime;
    public GameObject cam;
    private float maxDistance = 1.2f;
    public GameObject buttonE;
    public bool playerInArea=false;
    private void OnMouseEnter()
    {
        if (Vector3.Distance(cam.transform.position, transform.position) < maxDistance)
        {
            buttonE.SetActive(true);
            playerInArea = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInArea)
        {
            finishTime.timerRunning = true;
            finishTime.timeStart = 0;
            playerInArea = false;
            testRunning = true;

        }
    }
    private void OnMouseExit()
    {
        buttonE.SetActive(false);
    }
}
