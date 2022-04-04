/* Julian Salgado
 * Assignment 6
 * Makes prefabs move forward
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour, PrefabSetUp
{
    public float speed;

    protected virtual void Awake()
    {
        speed = 40;
    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
