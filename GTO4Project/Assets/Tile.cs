using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    
    public float x;
    public float y;
    public bool Occupied = false;

	// Use this for initialization
	void Start () {
        x = transform.position.x;
        y = transform.position.z;
	}
}
