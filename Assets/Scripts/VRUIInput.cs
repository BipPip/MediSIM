using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR;


namespace Valve.VR.Extras
{
[RequireComponent(typeof(SteamVR_LaserPointer))]


public class VRUIInput : MonoBehaviour
{
    private SteamVR_LaserPointer laserPointer;
    //private SteamVR_TrackedObject trackedController;
    //private SteamVR_Input_Sources inputSources;
    private SteamVR_Input_Sources trackedController;

    public SteamVR_Action_Boolean grabPinch; //Grab Pinch is the trigger, select from inspecter

    public event PointerEventHandler PointerIn;
    public event PointerEventHandler PointerOut;
    public event PointerEventHandler PointerClick;

    public SteamVR_Behaviour_Pose pose;

    private void OnEnable()
    {

        if (pose == null)
                pose = this.GetComponent<SteamVR_Behaviour_Pose>();
            if (pose == null)
                Debug.LogError("No SteamVR_Behaviour_Pose component found on this object", this);

            // if (interactWithUI == null)
            //     Debug.LogError("No ui interaction action has been set on this component.", this);


        laserPointer = GetComponent<SteamVR_LaserPointer>();
        // laserPointer.PointerIn -= OnPointerIn;
        // laserPointer.PointerIn += OnPointerIn;
        // laserPointer.PointerOut -= OnPointerOut;
        // laserPointer.PointerOut += OnPointerOut;

    //    inputSources = pose.inputSource;
    //    print(inputSources);
       
       trackedController = pose.inputSource;
       print(trackedController);
        // if (trackedController == null)
        // {
        //     trackedController = GetComponentInParent<SteamVR_TrackedController>();
        // }
        // trackedController.TriggerClicked -= HandleTriggerClicked;
        // trackedController.TriggerClicked += HandleTriggerClicked;

       /* if (grabPinch != null)
                {
                    grabPinch.AddOnChangeListener(OnTriggerPressedOrReleased, trackedController);
                }*/

    }

     private void OnDisable()
    {
       /* if (grabPinch != null)
        {
            grabPinch.RemoveOnChangeListener(OnTriggerPressedOrReleased, inputSource);
        }*/
    }
    

    public virtual void OnPointerIn(PointerEventArgs e)
        {
            if (PointerIn != null)
                PointerIn(this, e);
            print(PointerIn);
        }

        public virtual void OnPointerClick(PointerEventArgs e)
        {
            if (PointerClick != null)
                PointerClick(this, e);
        }

        public virtual void OnPointerOut(PointerEventArgs e)
        {
            if (PointerOut != null)
                PointerOut(this, e);
        }
}
}