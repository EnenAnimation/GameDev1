using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {

	Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void OnGUI () {
	
		if (GUILayout.Button ("Open Door")) 
		{
			animator.SetInteger ("DoorClose", 0);
			animator.SetInteger ("DoorOpen", 1);
		}

		if (GUILayout.Button ("Open Close")) 
		{
			animator.SetInteger ("DoorClose", 1);
			animator.SetInteger ("DoorOpen", 0);
		}
	}
}
