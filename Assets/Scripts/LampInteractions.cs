using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LampInteractions : XRBaseInteractable, ILightable
{
    [SerializeField] GameObject light;
    
    protected override void OnHoverEntered(HoverEnterEventArgs args)
    {
        base.OnHoverEntered(args);

        DebugXR.Instance.Log("OnHoverEntered : " + args.interactableObject.transform.gameObject.name);

        LightSwitch();

    }



    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        DebugXR.Instance.Log("OnSelectEntered : " + args.interactableObject.transform.gameObject.name);

        LightSwitch();
    }



    public void LightSwitch()
    {
        light.active = !light.active;
    }

    
}

