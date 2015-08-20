using UnityEngine;
using System.Collections;

public class mysideshot : MonoBehaviour {
	public float a;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		a += Time.deltaTime;
		if (a > 3) {
			GetComponentInChildren<ParticleSystem> ().Play ();
			a = 0;
		}
}
}
