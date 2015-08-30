using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class shot : MonoBehaviour {
	public int i = 200;
	public bool flag = true;
	public Text a;
	public bool flg = false;
	public bool fl = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update (){ 
		if (flg) s ();
		if (fl) r ();
	}
	public void s(){
		if (flag == true) {
			//if (Input.GetKey ("1")) {
				GetComponentInChildren<ParticleSystem> ().Play ();
				i --;
				a.text = i.ToString ();
			//}
		}
			if (i < 1) {
				flag = false; 
				StartCoroutine ("hogehoge");
			}
		}
		IEnumerator hogehoge(){
		yield return new WaitForSeconds(1);
				flag = true;
				i =  200;
				a.text = i.ToString();
			}
	public void r(){
		i = 200;
		a.text = i.ToString ();
	}
	public void change(){
		flg = !flg;
	}
	public void chan(){
		fl = !fl;
	}
		}

