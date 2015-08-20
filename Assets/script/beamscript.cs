using UnityEngine;
using System.Collections;

public class beamscript : MonoBehaviour {
	public   float a;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		a += Time.deltaTime;
		if (a > 3) {
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter(){
		if (gameObject.CompareTag ("Untagged")) {
				Destroy (gameObject);
			}
		}
}
