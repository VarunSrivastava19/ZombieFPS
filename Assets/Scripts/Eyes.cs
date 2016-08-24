using UnityEngine;
using System.Collections;

public class Eyes : MonoBehaviour
{
	private Camera eyes;
	private float defaultFOV;

	void Start ()
	{
		eyes = GetComponent<Camera> ();
	}

	void Update ()
	{
	
	}
}
