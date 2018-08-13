using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D _rigidbody2D;
    Collider2D _collider2D;
    public PhysicsMaterial2D NoBounce;
    public PhysicsMaterial2D Bounce;
    public Transform Resetpoint;
    public bool isBouncing;

    // Use this for initialization
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _collider2D= GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
         
            
        
    
    }
    public void ReSetPos() {
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.angularVelocity = 0;
        transform.position = Resetpoint.position;
        _collider2D.sharedMaterial= NoBounce;
    }
    public void BeforeShoot() {
        _collider2D.sharedMaterial = Bounce;
        isBouncing = true;
    }
}

