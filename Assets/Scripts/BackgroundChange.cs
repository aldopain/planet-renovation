using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChange : MonoBehaviour {
    public Color NewColor1;
    public Color NewColor2;
    Color StartColor;
    Color LerpColor;
    public float LerpTime;
    bool lerping;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(Camera.main.backgroundColor == NewColor1)
        {
            LerpColor = NewColor2;
            StartColor = NewColor1;
        }else
        {
            LerpColor = NewColor1;
            StartColor = NewColor2;
        }
    }
}
