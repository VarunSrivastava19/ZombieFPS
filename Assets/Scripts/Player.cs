using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public Transform playerSpawnPoints;
	public AudioClip whatHappened;
	public Helicopter helicopter;
	private Transform[] spawnPoints;
	private bool lastToggle = false;
	private bool reSpawn = false;
	private AudioSource innerVoice;

	void Start ()
	{
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();

		AudioSource[] audioSources = GetComponents<AudioSource> ();
		foreach (AudioSource audioSource in audioSources) {
			if (audioSource.priority == 1) {
				innerVoice = audioSource;
			}
		}

		innerVoice.clip = whatHappened;
		innerVoice.Play ();
	}

	void Update ()
	{
		if (lastToggle != reSpawn) {
			Respawn ();
			reSpawn = false;
		} else {
			lastToggle = reSpawn;
		}
	}

	private void Respawn ()
	{
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}

	void OnFindClearArea ()
	{
		Debug.Log ("found clear arena in player");
		helicopter.Call ();
	}
}
