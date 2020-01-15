﻿/*using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using Valve.VR;

namespace Valve.VR.Extras
{
	
[RequireComponent(typeof(SteamVR_LaserPointer))]
public class VRUIInput : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;
    //private SteamVR_TrackedController trackedController;
	 public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;

    private void OnEnable()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
        laserPointer.PointerIn -= HandlePointerIn;
        laserPointer.PointerIn += HandlePointerIn;
        laserPointer.PointerOut -= HandlePointerOut;
        laserPointer.PointerOut += HandlePointerOut;

        //trackedController = GetComponent<SteamVR_TrackedController>();
        trackedController = inputSource;
        if (trackedController == null)
        {
            trackedController = inputSource;
            trackedController = GetComponentInParent<SteamVR_TrackedController>();
        }
        trackedController.TriggerClicked -= HandleTriggerClicked;
        trackedController.TriggerClicked += HandleTriggerClicked;
    }

    private void HandleTriggerClicked(object sender, PointerEventArgs e)
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }
    }

    private void HandlePointerIn(object sender, PointerEventArgs e)
    {
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            button.Select();
            Debug.Log("HandlePointerIn", e.target.gameObject);
        }
    }

    private void HandlePointerOut(object sender, PointerEventArgs e)
    {
        
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Debug.Log("HandlePointerOut", e.target.gameObject);
        }
    }
}
}*/