using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VisionThreat : MonoBehaviour
{
    public bool SeePlayer { get; set; }
    private void Start()
    {
        SeePlayer = false;
    }
    private void OnTriggerEnter2D(Collider2D ColJump)
    {
        if (ColJump.CompareTag("player"))
        {
            SeePlayer = true;
            
            Debug.Log(false);
        }

    }
    private void OnTriggerExit2D(Collider2D ColJump)
    {
        if (ColJump.CompareTag("player"))
        {
            Debug.Log(true);
            SeePlayer = false;
        }

    }
}
