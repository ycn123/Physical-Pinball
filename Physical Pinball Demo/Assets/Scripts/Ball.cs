﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D _rigidbody2D;
    public float ForceSize=1;
    public Transform Resetpoint;
    // Use this for initialization
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 _direction = mousePos - transform.position;
            
            _direction.Normalize();
             
            _rigidbody2D.AddForce(_direction*ForceSize,ForceMode2D.Impulse);
        }
    }
    public void ReSetPos() {
        transform.position = Resetpoint.position;
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.angularVelocity = 0;
        
    }
}