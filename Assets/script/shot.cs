using UnityEngine;
using System.Collections;

public class shot : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("1")) {
			GetComponentInChildren<ParticleSystem> ().Play ();
		}
	}
}