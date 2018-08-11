using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstacleManager : MonoBehaviour {
    public GameObject[] AbstaclePrefabs;
    public float LowestY = -0.31f;
	// Use this for initialization
	void Start () {
    
    }

    // Update is called once per frame
    void Update () {
       
    }
    //建造最下面一行的障碍物
    public void AbstacleBuild() {
        var index = Random.Range(0, AbstaclePrefabs.Length);
        var prefab = AbstaclePrefabs[index];
        var pf = Instantiate(prefab);
        pf.transform.position = new Vector2(0, LowestY);
    }
}
