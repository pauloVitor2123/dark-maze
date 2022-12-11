using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    private float timer;
    public float score;
    public float cronometro;
    public bool TimerOn = false;
    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerOn)
        {
            if (cronometro > 0)
            {
                cronometro -= Time.deltaTime;
                updateTimer(cronometro);
            }
            else
            {
                cronometro = 0;
                TimerOn = false;
            }
        }

        float segundos = 200f;
        string sceneName = SceneManager.GetActiveScene().name;


        if (timer >= 1f && cronometro <= segundos)
        {
            if(sceneName == "LabirintoEasy")
            {
                score -= 1;
            }else if(sceneName == "LabirintoNormal")
            {

                score -= 1.5f;
            }
            else
            {
                score -= 2.5f;
            }

            timer = 0;

            int scoreInt = (int)score;
            scoreText.SetText("Score: " + scoreInt + "pts");

            if (score <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        int number = (int)score;
        PlayerPrefs.SetInt("Score", number);
    
        timer += Time.deltaTime;

    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
