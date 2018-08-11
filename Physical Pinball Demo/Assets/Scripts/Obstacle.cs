using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour {
    public int Hp = 5;
    public Text TextHp;
	// Use this for initialization
	void Start () {
        TextHp.text = Hp.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.collider.name);
        Hp -= 1;
        TextHp.text = Hp.ToString();
        if (Hp <= 0) {
            Destroy(gameObject);
            Destroy(TextHp);
        }
    }
}
