using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationRayBehaviour : MonoBehaviour
{
    public XRRayInteractor TeleportationRay;
    public InputHelpers.Button activationButton;

    // Update is called once per frame
    void Update()
    {
        if (!TeleportationRay) return;
        var TeleportationRayController = TeleportationRay.GetComponent<XRController>();
        TeleportationRay.gameObject.SetActive(CheckActivation(TeleportationRayController));
    }

    public bool CheckActivation(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, activationButton, out bool isActive, 0.1f);
        return isActive;
    }
}
