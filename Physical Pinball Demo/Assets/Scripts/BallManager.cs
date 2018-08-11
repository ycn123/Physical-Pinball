using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {
    public float ShootInterval = 0.5f;
    public float ForceSize = 10;
    public Transform ShootPoint;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(ShootBalls());
           
        }
    }
    IEnumerator ShootBalls()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 _direction = mousePos - ShootPoint.position;
        

        _direction.Normalize();
        for (int i = 0; i < transform.childCount; i++) {
            var child = transform.GetChild(i);
            child.GetComponent<Ball>().BeforeShoot();
            child.transform.position = ShootPoint.position;
            var rg = child.GetComponent<Rigidbody2D>();
            rg.AddForce(_direction * ForceSize, ForceMode2D.Impulse);
            yield return new WaitForSeconds(ShootInterval);
        }
    }
}
