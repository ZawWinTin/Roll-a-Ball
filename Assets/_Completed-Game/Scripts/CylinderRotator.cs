﻿using UnityEngine;
using System.Collections;

public class CylinderRotator : MonoBehaviour
{
    public float speed;
    // Before rendering each frame..
    void Update()
    {
        // Rotate the game object that this script is attached to by 15 in the X axis,
        // 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
        // rather than per frame.
        //transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, 200) * Time.deltaTime);
    }
}