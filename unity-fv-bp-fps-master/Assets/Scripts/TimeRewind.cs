
using System.Collections.Generic;
using UnityEngine;

public class TimeRewind : MonoBehaviour
{
    public bool isRewinding;
    public float recordTime = 5f;
    public int rewindSlots = 5;

    public PlayerCharacterController input;
    private List<PointInTime> pointsInTime;
    private Health health;

    void Start()
    {
        input = GetComponent<PlayerCharacterController>();
        pointsInTime = new List<PointInTime>();
        health = GetComponent<Health>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && rewindSlots > 0)
        {
            if (health.currentHealth > 0)
            {
                StartRewind();
            }
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            StopRewind();
        }
    }

    void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }
        else
        {
            Record();
        }
    }

    void Record()
    {
        if (pointsInTime.Count > Mathf.Round( recordTime / Time.fixedDeltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }
        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation, health.currentHealth));
    }

    void Rewind()
    {
        PointInTime point = pointsInTime[0];
        transform.position = point.position;
        transform.rotation = point.rotation;
        health.currentHealth = point.healthPoints;
        pointsInTime.RemoveAt(0);
    }

    void StartRewind()
    {
        input.enabled = false;
        isRewinding = true;
        rewindSlots--;
    }

    void StopRewind()
    {
        input.enabled = true;
        isRewinding = false;
    }
}
