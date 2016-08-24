using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public Transform playerSpawnPoints;
	// The parent of the spawn point
	public bool reSpawn = false;

	private Transform[] spawnPoints;

	void Start ()
	{
		spawnPoints = GetComponentInChildren<Transform> ();
	}

	void Update ()
	{
	
	}

	private void Respawn ()
	{
		int i = Random.Range (1, spawnPoints.Length);
	}

}
