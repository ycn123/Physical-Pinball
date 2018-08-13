using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] ObstaclePrefabs;
    public GameObject TextPrefab;
    public Transform CanvasParent;
    public float LowestY = -3.1f;
    // Use this for initialization
    void Start()
    {
        ObstacleBuild();
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //建造最下面一行的障碍物
    public void ObstacleBuild()
    {
        var index = Random.Range(0, ObstaclePrefabs.Length);
        var prefab = ObstaclePrefabs[index];
        var pf = Instantiate(prefab, transform);
        pf.transform.position = new Vector2(0, LowestY);
        var ui = TextBuild();
        pf.GetComponent<Obstacle>().Initialize(ui);
    }
    GameObject TextBuild()
    {
        var ui = Instantiate(TextPrefab, CanvasParent);
        return ui;
    }
}

