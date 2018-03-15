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
        //Wood.handler += UpdateUIWood;
        //Gold.handler += UpdateUIGold;
        //Stone.handler += UpdateUIStone;

        Wood.handler += UpdateUIHandler;
        Gold.handler += UpdateUIHandler;
        Stone.handler += UpdateUIHandler;
        UpdateUI();
    }

    //public void UpdateUIWood(object obj, EventArgs args)
    //{
    //    ResourceModel resource = (ResourceModel)obj;
    //    WoodText.text = "Amount of Wood: " + resource.CurrentOwned;
    //}
    //public void UpdateUIGold(object obj, EventArgs args)
    //{
    //    ResourceModel resource = (ResourceModel)obj;
    //    GoldText.text = "Amount of Gold: " + resource.CurrentOwned;
    //}
    //public void UpdateUIStone(object obj, EventArgs args)
    //{
    //    ResourceModel resource = (ResourceModel)obj;
    //    StoneText.text = "Amount of Stone: " + resource.CurrentOwned;
    //}

    public void UpdateUIHandler(object obj, EventArgs args)
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        Debug.Log(Wood.CurrentOwned);
        WoodText.text = "Amount of Wood: " + Wood.CurrentOwned;
        GoldText.text = "Amount of Gold: " + Gold.CurrentOwned;
        StoneText.text = "Amount of Stone: " + Stone.CurrentOwned;
    }


}
