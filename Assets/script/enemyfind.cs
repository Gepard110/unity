using UnityEngine;
using System.Collections;

public class enemyfind : MonoBehaviour {
	public GameObject player;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("unitychan");
		agent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (player.transform.position);
	}
}
