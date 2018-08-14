using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDouble : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.localScale *= 1.25f;
        collision.GetComponent<Ball>().Damage = 2;
        Destroy(gameObject);
    }
}
