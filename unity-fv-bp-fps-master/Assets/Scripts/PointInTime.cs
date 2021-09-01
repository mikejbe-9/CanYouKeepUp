using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointInTime
{
    public Vector3 position;
    public Quaternion rotation;
    public float healthPoints;

    public PointInTime(Vector3 pos, Quaternion rot, float hp)
    {
        position = pos;
        rotation = rot;
        healthPoints = hp;
    }
}
