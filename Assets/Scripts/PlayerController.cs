using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour

{
    public Stopwatch stopwatch; // Verknüpfe die Stoppuhr im Inspector
    public GameObject gameOverScreen; // Verknüpfe den Game Over-Bildschirm im Inspector

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        stopwatch.Stop(); // Stoppe die Stoppuhr
        gameOverScreen.SetActive(true); // Zeige den Game Over-Bildschirm an
        Time.timeScale = 0f; // Pausiere das Spiel
    }
}
