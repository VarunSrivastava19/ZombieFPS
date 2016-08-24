using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public Transform playerSpawnPoints;
	// The parent of the spawn point
	private bool reSpawn = false;
	public Helicopter helicopter;
	private Transform[] spawnPoints;
	private bool lastToggle = false;

	void Start ()
	{
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
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
		Debug.Log ("foudn clear arena in player");
		helicopter.Call ();
	}
}
