using UnityEngine;
using System.Collections;

public class manageLev : MonoBehaviour {
	public GameObject Next;

	public GameObject Picture_answer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void EndLevel(){
		GameObject calc = GameObject.Find ("okno_calc");
		GameObject pict_answ = GameObject.Find ("picter_answered_wind");
		if (calc != null) {
			Destroy(calc);
		}
		if (pict_answ != null) {
			Destroy(pict_answ);
		}
		Instantiate (Next);
		Debug.Log ("endLevel");

	}
}
