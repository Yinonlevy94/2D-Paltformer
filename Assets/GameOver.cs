using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI; // Reference to the game over UI Panel.
    public Text gameOverText;     // Reference to the UI Text element.

    private void Start()
    {
        gameOverUI.SetActive(false); // Make sure the game over UI is initially inactive.
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
            gameOverUI.SetActive(true);

            
            gameOverText.text = "Game Over"; 
        }
    }
}
