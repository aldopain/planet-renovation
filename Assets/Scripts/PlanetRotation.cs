using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {
    public float Speed;
    Rigidbody2D body;
	// Use this for initialization
	void Start () {
        
	}

    void Update()
    {
        transform.Rotate(0, 0, Speed);
    }

}
