using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOne : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var oldball = collision.gameObject;
        Instantiate(oldball, collision.transform.parent);
        Destroy(gameObject);
    }
}
