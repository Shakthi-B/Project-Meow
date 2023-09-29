using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Cainos.PixelArtTopDown_Basic.TopDownCharacterController player;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timeText;
    private string Text;

    public TextMeshProUGUI ButtonText;

    // Start is called before the first frame update
    void Start()
    {
        // Starts the timer automatically
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {

                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                player.speed = 5;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {

        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void Meditate()
    {
        if (timeText.text == "MEDITATE \n NOW" || Text == "MEDITATE \n NOW")
        {
            Text = "MEDITATE \n NOW";
            if (!timerIsRunning)
            {
                timerIsRunning = true;
                ButtonText.text = "CANCEL";
                timeRemaining = 600;
                player.speed = 0;
            }
            else
            {
                timerIsRunning = false;
                timeText.text = "MEDITATE \n NOW";
                ButtonText.text = "GO!!!";
                player.speed = 5;
            }
        }
        if (timeText.text == "SLEEP \n NOW" || Text == "SLEEP \n NOW")
        {
            Text = "SLEEP \n NOW";
            if (!timerIsRunning)
            {
                timerIsRunning = true;
                ButtonText.text = "CANCEL";
                timeRemaining = 3600;
                player.speed = 0;
            }
            else
            {
                timerIsRunning = false;
                timeText.text = "SLEEP \n NOW";
                ButtonText.text = "GO!!!";
                player.speed = 5;
            }
        }
        if (timeText.text == "CHAT \n NOW" || Text == "CHAT \n NOW")
        {
            Text = "CHAT \n NOW";
            if (!timerIsRunning)
            {
                timerIsRunning = true;
                ButtonText.text = "CANCEL";
                timeRemaining = 900;
                player.speed = 0;
            }
            else
            {
                timerIsRunning = false;
                timeText.text = "CHAT \n NOW";
                ButtonText.text = "GO!!!";
                player.speed = 5;
            }
        }

        if (timeText.text == "READ \n NOW" || Text == "READ \n NOW")
        {
            Text = "READ \n NOW";
            if (!timerIsRunning)
            {
                timerIsRunning = true;
                ButtonText.text = "CANCEL";
                timeRemaining = 900;
                player.speed = 0;
            }
            else
            {
                timerIsRunning = false;
                timeText.text = "READ \n NOW";
                ButtonText.text = "GO!!!";
                player.speed = 5;
            }
        }

    }
}
