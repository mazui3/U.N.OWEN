﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDoorStuck : MonoBehaviour
{
    public bool stuckDoor = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            stuckDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        stuckDoor = false;
    }
}
