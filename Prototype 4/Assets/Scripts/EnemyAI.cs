using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Rigidbody enemyRb;
    public GameObject player;
    public float speed = 3.0f;

    public DisplayWaves waveIncrease;

    // Start is called before the first frame update
    void Start()
    {
        waveIncrease = FindObjectOfType<DisplayWaves>();
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            waveIncrease.wave++;
        }
    }
}
