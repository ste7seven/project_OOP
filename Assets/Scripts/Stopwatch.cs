using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    public Text stopwatchText; // Verknüpfe den UI-Text im Inspector
    private float elapsedTime = 0f;
    private bool isRunning = true;

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60f);
            int seconds = Mathf.FloorToInt(elapsedTime % 60f);
            stopwatchText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    public void Stop()
    {
        isRunning = false;
    }
}

