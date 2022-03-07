/* Julian Salgado
 * Assignment 5A
 * Controls score, win condiitons, lose conditions, and restarting
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

    public PlayerPlatformerController playerScript;

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
            playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPlatformerController>();
        }

        scoreText.text = "Collect 10 gems\nScore: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerScript.gameOver)
        {
            scoreText.text = "Collect 10 gems\nScore: " + score;
        }

        if (score >= 10)
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
