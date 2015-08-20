using UnityEngine;
using System.Collections;

public class mysidefind : MonoBehaviour {
	public GameObject enemy;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		enemy = GameObject.Find ("enemy");
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (enemy.transform.position);
	}
}
