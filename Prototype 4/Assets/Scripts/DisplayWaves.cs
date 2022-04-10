using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayWaves : MonoBehaviour
{
    public Text textbox;

    public int wave = 1;

    public PlayerController player;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        textbox = FindObjectOfType<Text>();
        
        textbox.text = "Wave: 1";
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameOver)
        {
            textbox.text = "Wave: " + wave;
        }

        if (player.gameOver && !won)
        {
            textbox.text = "Game Over!\nPress R to restart";
        }

        if (wave >= 10)
        {
            player.gameOver = true;
            textbox.text = "You win!\nPress R to restart";
            won = true;
        }

        if (player.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
