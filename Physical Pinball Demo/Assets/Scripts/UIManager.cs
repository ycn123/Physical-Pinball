using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public static UIManager instace;
    public Text Scoure;
    private void Awake()
    {
        instace = this;
    }
}
