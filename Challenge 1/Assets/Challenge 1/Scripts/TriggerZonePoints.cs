/*
 * Julian Salgado
 * Challenge 1
 * adds score when player enters trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZonePoints : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
