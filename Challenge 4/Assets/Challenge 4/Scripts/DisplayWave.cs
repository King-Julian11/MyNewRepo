/* Julian Salgado
 * Assignment 7
 * Displays UI and determines win/loss conditions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayWave : MonoBehaviour
{
    public Text textbox;

    public SpawnManagerX spawn;

    public int wave = 1;

    public bool won = false;

    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        textbox = FindObjectOfType<Text>();

        textbox.text = "Wave: 1";

        spawn = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            wave = spawn.waveCount - 1;
            textbox.text = "Wave: " + wave;
        }

        if (gameOver && !won)
        {
            textbox.text = "Game Over!\nPress R to restart";
        }

        if (spawn.waveCount >= 10)
        {
            gameOver = true;
            textbox.text = "You win!\nPress R to restart";
            won = true;
        }

        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
