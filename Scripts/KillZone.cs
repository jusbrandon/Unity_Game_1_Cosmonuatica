﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            playerHealth die = other.gameObject.GetComponent<playerHealth>();
            die.makeDead();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            
            playerHealth die = other.gameObject.GetComponent<playerHealth>();
            die.makeDead();
        }
    }
}
