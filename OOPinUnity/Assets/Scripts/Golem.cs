/* Julian Salgado
 * Assignment 6
 * Creates golem
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{
    protected int damage;

    // Start is called before the first frame update
    protected override void Awake()
    {
        base.Awake();
        health = 120;
        //GameManager.score = 5;
        GameManager.Instance.score += 2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Golem attacks!");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + " points of damage!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
