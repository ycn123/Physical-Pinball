﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleManager : MonoBehaviour {
    public GameObject[] ObstaclePrefabs;
    public GameObject pf;
    public GameObject ui;
    public float LowestY = -3.1f;
    public GameObject TextPrefab;
    public Transform CanvasParent;
    public float[] HorizontalPos = { 0, 0.95f, 1.9f, -0.95f, -1.9f };
    public static ObstacleManager Instance;
    void Start()
    {
        Instance = this;
        ObstacleBuild();
    }


    public void ObstacleBuild()
    {
        foreach (var item in HorizontalPos) {
            var random = Random.Range(0, 10);
            if (random == 0) continue;
            var index = Random.Range(0, ObstaclePrefabs.Length);
            var prefab = ObstaclePrefabs[index];

            pf = Instantiate(prefab, transform);
            pf.transform.position = new Vector2(item, LowestY);

            var ui = TextBuild();
            pf.GetComponent<Obstacle>().Initialize(ui);
        }

    }
    GameObject TextBuild()
    {
        if (pf.GetComponent<Obstacle>() != null)
        {
           ui = Instantiate(TextPrefab, CanvasParent);
            
        }
        return ui;
    }
    public void ObstaclesUp() {
        foreach (Transform item in transform) {
            item.position += new Vector3(0, 1f, 0);
           var obstacle= item.GetComponent<Obstacle>();
                if(obstacle != null) obstacle.UpdateUI();
        }
        ObstacleBuild();
    }
}
