using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour {
    public int Hp = 5;
    public Text TextHp;
	// Use this for initialization
	
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
    //用于障碍物的初始化 关联
    public void Initialize(GameObject ui)
    {
        TextHp = ui.GetComponent<Text>();
        var pos = Camera.main.WorldToScreenPoint(transform.position);
    }
}
