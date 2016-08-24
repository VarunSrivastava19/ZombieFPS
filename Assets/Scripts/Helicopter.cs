﻿using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour
{
	private bool called = false;
	public AudioClip callSound;

	private AudioSource audioSource;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
		rigidBody = GetComponent<Rigidbody> ();
	}

	public void Call ()
	{
		if (!called) {
			called = true;
			audioSource.clip = callSound;
			audioSource.Play ();
			rigidBody.velocity = new Vector3 (0, 0, 50f);
		}
	}

}
