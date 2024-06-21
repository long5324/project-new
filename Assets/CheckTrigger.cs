using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger: MonoBehaviour
{
    public bool EnterTrigger { get; set; }
    public Collider2D ColJump;
    public string Tag ;

    private void Start()
    {
        EnterTrigger = false;
    }
     void OnTriggerEnter2D(Collider2D ColJump)
    {
        Debug.Log(EnterTrigger);
        if (ColJump.CompareTag(Tag))
        {
            EnterTrigger = true;
            Debug.Log(EnterTrigger);
        }
            
    }
    private void OnTriggerExit2D(Collider2D ColJump)
    {
        if (ColJump.CompareTag(Tag))
        {
            EnterTrigger = false;
            Debug.Log(EnterTrigger);
        }
    }
}
