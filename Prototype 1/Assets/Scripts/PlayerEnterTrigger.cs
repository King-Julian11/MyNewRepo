/*
 * Julian Salgado
 * Prototype 1
 * trigger zones for score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to Player
public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }

}
