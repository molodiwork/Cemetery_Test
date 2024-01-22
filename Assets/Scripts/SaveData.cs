using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour
{
    public GameObject hUD;
    public MouseLook control;
    public GameObject leaderBoard;
    public GameObject nameInput;
    public TimerRun score;
    public TMPro.TextMeshProUGUI myScore;
    public TMPro.TextMeshProUGUI myName;
    public int currentScore;
   
    void Update()
    {
        currentScore = (int)score.timeStart;
        myScore.text = currentScore.ToString();
    }
    public void SendScore()
    {
        nameInput.SetActive(false);
        PlayerPrefs.SetInt("highscore", currentScore);
        HighScores.UploadScore(myName.text, currentScore);
        
    }
    public void CloseBoard()
    {
        hUD.SetActive(true);
        leaderBoard.SetActive(false);
        control.gameObject.GetComponent<MouseLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
