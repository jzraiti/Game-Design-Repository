﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{

	private Rigidbody2D rb2d;

	public float speed; 

	// Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }
    void FixedUpdate()
    {
    	float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
    	Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

    	rb2d.AddForce(movement * speed); 
    }


    
}
