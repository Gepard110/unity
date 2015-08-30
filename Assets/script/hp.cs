using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hp : MonoBehaviour {
	public int life = 120;
	public Text a; 
	public bool flg = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (life < 1) {
			Debug.Log ("DIED");
		}
	}

	public void test(){
		if (flg == true) {
			flg = false;
			life -= 1;
			a.text = life.ToString ();
			StartCoroutine ("hogehoge");
		}
	}
		IEnumerator hogehoge(){
			yield return new WaitForSeconds(2);
			flg = true;
		}
	}
