/* Julian Salgado
 * Assignment 6
 * Interface for health system
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Health
{
    void Update();
    void TakeDamage();

    void AddMaxHealth();
}
