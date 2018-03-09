using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceModel : MonoBehaviour {

    public event EventHandler handler;

    public int StartAmount;

    private int currentOwned;

    public int CurrentOwned
    {
        get { return currentOwned; }
        set {
            currentOwned = value;

            if(handler != null)
            {
                handler(this, new EventArgs());
            }
        }
    }

    

	// Use this for initialization
	void Start () {
        currentOwned = StartAmount;


	}

    
}
