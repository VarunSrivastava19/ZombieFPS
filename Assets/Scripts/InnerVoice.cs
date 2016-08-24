using UnityEngine;
using System.Collections;

public class InnerVoice : MonoBehaviour
{

	public AudioSource whatHappened;
	public AudioClip goodLandingArea;

	private AudioSource audioSource;

	// Use this for initialization
	void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
