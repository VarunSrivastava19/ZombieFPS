using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public Transform playerSpawnPoints;
	public Helicopter helicopter;
	public GameObject landingAreaPrefab;
	private Transform[] spawnPoints;
	private bool lastRespawnToggle = false;
	private bool reSpawn = false;

	void Start ()
	{
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();

	}

	void Update ()
	{
		if (lastRespawnToggle != reSpawn) {
			Respawn ();
			reSpawn = false;
		} else {
			lastRespawnToggle = reSpawn;
		}
	}

	private void Respawn ()
	{
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}

	void OnFindClearArea ()
	{
		Invoke ("DropFlare", 3f);
	}

	void DropFlare ()
	{
		Instantiate (landingAreaPrefab, transform.position, transform.rotation);
	}
}
