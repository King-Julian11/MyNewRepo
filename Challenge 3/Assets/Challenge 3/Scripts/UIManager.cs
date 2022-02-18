/*
 * Julian Salagdo
 * Assignment 4
 * Manages score, restart, and win and lose conditions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public PlayerControllerX playerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerScript == null)
        {
            playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if (playerScript.gameOver && !won)
        {
            scoreText.text = "You lose!\nPress R to Try Again!";
        }

        if (score >= 30)
        {
            playerScript.gameOver = true;
            won = true;

            scoreText.text = "You win!\nPress R to Try Again!";
        }

        if (playerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
