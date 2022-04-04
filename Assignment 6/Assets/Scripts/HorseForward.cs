/* Julian Salgado
 * Assignment 6
 * Makes horses move forward
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseForward : MoveForward
{
    protected override void Awake()
    {
        speed = 15;
    }
}