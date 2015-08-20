using UnityEngine;
using System.Collections;

public class mysidescript : MonoBehaviour {
	public GameObject a;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag ("Item")) {
			test ();
		}
	}
	
	public void test ()
	{
		Instantiate (a,new Vector3(Random.Range (0,30),0,30), Quaternion.identity);
		Destroy (gameObject);
	}
}
