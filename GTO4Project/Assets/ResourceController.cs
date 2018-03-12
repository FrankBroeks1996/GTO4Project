using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class ResourceController : MonoBehaviour {

    public Button Button;

    public void RemoveResource(ResourceModel resourceModel, int subtractValue)
    {
        resourceModel.CurrentOwned -= subtractValue;
    }

    public void AddResource(ResourceModel resourceModel, int advanceValue)
    {
        resourceModel.CurrentOwned += advanceValue;
    }

}
