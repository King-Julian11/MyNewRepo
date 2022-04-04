/* Julian Salgado
 * Assignment 6
 * Makes moose move forward
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MooseForward : MoveForward
{
    protected override void Awake()
    {
        speed = 16;
    }
}