﻿using UnityEngine;
using System.Collections;

public class particle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnParticleCollision(GameObject obj){
		if(obj.GetComponent<Collider>().gameObject.tag == "Player"){
			obj.SendMessage ("test");
		}
}
}

