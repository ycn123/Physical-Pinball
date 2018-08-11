using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstacleManager : MonoBehaviour {
    public GameObject[] AbstaclePrefabs;
    public GameObject TextPrefab;
    public Transform CanvasParent;
    public float LowestY = -3.1f;
	// Use this for initialization
	void Start () {
        AbstacleBuild();
    }

    // Update is called once per frame
    void Update () {
       
    }
    //建造最下面一行的障碍物
    public void AbstacleBuild() {
        var index = Random.Range(0, AbstaclePrefabs.Length);
        var prefab = AbstaclePrefabs[index];
        var pf = Instantiate(prefab,transform);
        pf.transform.position = new Vector2(0, LowestY);
        var ui = TextBuild();
        pf.GetComponent<Obstacle>().Initialize(ui);
    }
    GameObject TextBuild() {
        var ui = Instantiate(TextPrefab,CanvasParent);
        return ui;
    }
}
