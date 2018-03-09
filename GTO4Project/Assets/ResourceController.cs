using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class ResourceController : MonoBehaviour {

    public Button Button;
    public ResourceModel Resource;

    public void RemoveResource(ResourceModel resourceModel)
    {
        //Resource.CurrentOwned--;
    }

    public void AddResource(ResourceModel resourceModel)
    {
        //Resource.CurrentOwned++;
        resourceModel.CurrentOwned++;
    }

}
