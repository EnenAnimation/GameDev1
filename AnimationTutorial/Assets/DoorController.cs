using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	public Animator animator;
	public Rect openDoorRectangle;
	public Rect closeDoorRectangle;

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
	
		if (GUI.Button (openDoorRectangle, "DoorOpen")) 
		{
			animator.SetInteger ("DoorOpen", 1);
			animator.SetInteger ("DoorClose", 0);
		}
		if(GUI.Button(closeDoorRectangle, "DoorClose")) 
		{
			animator.SetInteger ("DoorOpen", 0);
			animator.SetInteger ("DoorClose", 1);
			
				
		}
	}
}
