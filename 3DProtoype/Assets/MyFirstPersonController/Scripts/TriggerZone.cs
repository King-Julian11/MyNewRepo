/* Julian Salgado
 * Assignment 5B
 * Makes trigger zone at the end of the level
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    private bool triggered = false;
    private bool won = false;
    public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            won = true;
        }

        if (won)
        {
            textbox.text = "You win!";
        }
    }
}
