using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Rigidbody2D _rigidbody2D;
    Collider2D _collider2D;
    public PhysicsMaterial2D NoBounce;
    public PhysicsMaterial2D Bounce;
    public Transform Resetpoint;
    public Transform Backpoint1;
    public Transform Backpoint2;
    public bool isBouncing;
    public int Damage=1;

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
        var seq=LeanTween.sequence();
        seq.append(LeanTween.move(gameObject,Backpoint1.position,0.2f));
        seq.append(LeanTween.move(gameObject,Backpoint2.position, 1f));
        seq.append(LeanTween.move(gameObject,Resetpoint.position, 0.1f));
        seq.append(OnBackAnimationOver);
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
    void OnBackAnimationOver() {
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.angularVelocity = 0;
        transform.position = Resetpoint.position;
        _collider2D.sharedMaterial = NoBounce;
        gameObject.layer = 0;
        isBouncing = false;
        GetComponent<SpriteRenderer>().color = Color.white;
        transform.GetComponentInParent<BallManager>().OnBallsBack();
   
    }
    public void BeforeShoot() {
        _collider2D.sharedMaterial = Bounce;
        isBouncing = true;
        gameObject.layer = 8;
        _rigidbody2D.velocity = Vector2.zero;
        _rigidbody2D.angularVelocity = 0;
    }
}

