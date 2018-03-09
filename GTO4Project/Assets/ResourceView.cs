using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceView : MonoBehaviour {

    public ResourceController ResourceController;
    public ResourceModel Wood;
    public ResourceModel Gold;
    public ResourceModel Stone;

    public Text WoodText;
    public Text GoldText;
    public Text StoneText;

    // Use this for initialization
    void Awake () {
        Wood.handler += UpdateUIWood;
        Gold.handler += UpdateUIGold;
        Stone.handler += UpdateUIStone;
    }

    public void UpdateUIWood(object obj, EventArgs args)
    {
        WoodText.text = "Amount of Wood: " + Wood.CurrentOwned;
    }
    public void UpdateUIGold(object obj, EventArgs args)
    {
        GoldText.text = "Amount of Gold: " + Gold.CurrentOwned;
    }
    public void UpdateUIStone(object obj, EventArgs args)
    {
        StoneText.text = "Amount of Stone: " + Stone.CurrentOwned;
    }


}
