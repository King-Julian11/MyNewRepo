/*
 * Julian Salagdo
 * Assignment 4
 * Creates trigger zones to add score
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{

    private UIManager uiManager;

    private bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uiManager.score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
