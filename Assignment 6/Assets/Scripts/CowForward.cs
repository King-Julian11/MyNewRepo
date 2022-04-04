/* Julian Salgado
 * Assignment 6
 * Makes cows move forward
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowForward : MoveForward
{
    protected override void Awake()
    {
        speed = 18;
    }
}
