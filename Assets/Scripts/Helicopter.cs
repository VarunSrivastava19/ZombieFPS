using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour
{
	private bool called = false;
	public AudioClip callSound;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("CallHeli") && !called) {
			called = true;
			//play sound
			print ("heli calleld");
		}
	}
}
