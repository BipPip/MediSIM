using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LaserInput : MonoBehaviour
{
	
	public SteamVR_Action_Boolean TriggerClick;
   /// private SteamVR_Input_Sources inputSource;
	public SteamVR_Input_Sources inputSource = SteamVR_Input_Sources.Any;
	public static GameObject currentObject;
	
	int currentID;
    // Start is called before the first frame update
    void Start()
    {
        currentObject = null;
		currentID = 0;
    }
	
	private void OnEnable()
    {
        TriggerClick.AddOnStateDownListener(Press, inputSource);
    }
	
	private void OnDisable()
    {
        TriggerClick.RemoveOnStateDownListener(Press, inputSource);
    }
 
    private void Press(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        //put your stuff here
        print("Success");
    }

    // Update is called once per frame
    void Update()
    {
		//Sends out a Raycast and returns an array filled with everything it hit
		RaycastHit[] hits;
		hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);
		
		//Goes through all the hit objects and checks if any of them were our button
		for (int i = 0; i < hits.Length; i++) 
		{
			RaycastHit hit = hits[i];
			
			//I use the object Id to determine if I have already run the code for this object
			int id = hit.collider.gameObject.GetInstanceID();
			
			//If I haven't then I will run it again but if I have it is unnecessary to keep running it
			if (currentID != id)
			{
				currentID = id;
				currentObject = hit.collider.gameObject;
				
				
				//Checks based off the namespace
				string name = currentObject.name;
				if (name == "Play")
				{
					Debug.Log("HIT PLAY");
					Application.LoadLevel("lab");
				}
				
				//Checks based off the tag
				string tag = currentObject.tag;
				if(tag == "Button")
				{
					Debug.Log("HIT BUTTON");
				}
				
			}	

			}
	}
}
