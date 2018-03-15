using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class ResourceController : MonoBehaviour {

    public Button Button;

    public void RemoveResource(ResourceModel resourceModel)
    {
        resourceModel.CurrentOwned -= 1;
    }

    public void AddResource(ResourceModel resourceModel)
    {
        resourceModel.CurrentOwned += 1;
    }

}
