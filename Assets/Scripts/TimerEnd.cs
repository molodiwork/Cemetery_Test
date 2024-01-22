using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerEnd : MonoBehaviour
{
    public ButtonOn check;
    public MouseLook control;
    public GameObject hUD;
    public GameObject board;
    public TimerRun finishTime;
    public GameObject cam;
    private float maxDistance = 1.2f;
    public GameObject buttonE;
    public bool playerInArea = false;
    private void OnMouseEnter()
    {
        if (Vector3.Distance(cam.transform.position, transform.position) < maxDistance && check.testRunning)
        {
            buttonE.SetActive(true);
            playerInArea = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInArea)
        {
            finishTime.timerRunning = false;
            playerInArea = false;
            control.gameObject.GetComponent<MouseLook>().enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            hUD.SetActive(false);
            board.SetActiveRecursively(true);
            check.testRunning = false;
        }
    }
    private void OnMouseExit()
    {
        playerInArea = false;
        buttonE.SetActive(false);
    }
}
