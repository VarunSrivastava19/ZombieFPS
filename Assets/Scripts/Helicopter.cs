using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour
{
	private bool called = false;
	public AudioClip callSound;

	private AudioSource audioSource;

	// Use this for initialization
	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("CallHeli") && !called) {
			called = true;
			audioSource.clip = callSound;
			audioSource.Play ();
		}
	}
}
