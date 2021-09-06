using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    [SerializeField] private float slowTimeVal = 0.3f;
    [SerializeField] private float slowMoSpeed = 3f;
    [SerializeField] private float slowMoMaxTime = 3f;

    public float timeCounter = 0f;
    public bool isSlowingDown;
    public int slowMoSlots = 3;

    void Update()
    {
        if (isSlowingDown)
        {
            timeCounter += Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.B) && slowMoSlots > 0)
        {
            isSlowingDown = true;
            StartSlowMo();
        }
        if(timeCounter >= slowMoMaxTime)
        {
            isSlowingDown = false;
            timeCounter = 0f;
            //Time.timeScale = Mathf.Lerp(slowTimeVal, 1f, slowMoSpeed * Time.deltaTime);
            Time.timeScale = 1f;
        }
    }

    void StartSlowMo()
    {
        if (timeCounter < slowMoMaxTime)
        {
            Time.timeScale = 0.3f;
            //Time.timeScale = Mathf.Lerp(1f, slowTimeVal, slowMoSpeed * Time.deltaTime);
            slowMoSlots--;
        }
    }
}
