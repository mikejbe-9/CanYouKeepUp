using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleHook : MonoBehaviour
{
    [SerializeField] private float swingingSpeed = 70f;
    [SerializeField] private float length = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown(GameConstants.k_ButtonNameAction))
        {
            if(Physics.Raycast(transform.position, transform.forward, out RaycastHit rayCastHit, length))
            {

            }
        }
    }
}
