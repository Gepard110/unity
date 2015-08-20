using UnityEngine;
using System.Collections;

public class enemyshot : MonoBehaviour
{
//	public float endtime;
//	public GameObject b;
//	public Transform c;
	public float a;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
//		endtime += Time.deltaTime;
//		if(endtime >= 3.0f){
//			endtime = 0;
//			GameObject obj = GameObject.Instantiate(b)as GameObject;
//			obj.transform.position = c.position;
//			Vector3 force;
//			force = this.gameObject.transform.forward * 300;
//			obj.GetComponent<Rigidbody>().AddForce (force);
//		}
		a += Time.deltaTime;
		if (a > 3) {
			GetComponentInChildren<ParticleSystem> ().Play ();
			a = 0;
		}
	}
}