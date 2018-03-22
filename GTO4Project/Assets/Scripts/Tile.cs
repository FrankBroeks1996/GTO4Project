using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
    
    public float x;
    public float y;
    public Unit UnitOnTile;
    public bool IsHighLight = false;

	// Use this for initialization
	void Start () {
        x = transform.position.x;
        y = transform.position.z;
	}

    public void HighLight()
    {
        IsHighLight = !IsHighLight;
        if (IsHighLight)
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        
    }
}
