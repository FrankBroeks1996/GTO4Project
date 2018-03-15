using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //public Resources resources;
    public Color color;
    public UnitFactory tankFactory;
    public List<GameObject> Units;

    public void BuyUnit() {
        Units.Add(tankFactory.InstantiateUnit());
    }
}
