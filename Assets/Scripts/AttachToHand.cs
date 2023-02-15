using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AttachToHand : MonoBehaviour
{
    // Start is called before the first frame update
    public void attach(SelectEnterEventArgs arg)
    {
        GetComponent<XRInteractorLineVisual>().enabled = false;
       // arg.interactableObject.transform.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    public void remove(SelectExitEventArgs arg)
    {
        GetComponent<XRInteractorLineVisual>().enabled = true;
       // arg.interactableObject.transform.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
