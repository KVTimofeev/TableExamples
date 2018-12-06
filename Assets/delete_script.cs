using UnityEngine;
using System.Collections;

public class delete_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){

		TextMesh txtOnAnswer = (TextMesh)GameObject.Find ("picter_answered_wind").GetComponentInChildren<TextMesh> () as TextMesh;
		if (txtOnAnswer.text.Length > 0) {
			txtOnAnswer.text = txtOnAnswer.text.Remove (txtOnAnswer.text.Length - 1);
			if(txtOnAnswer.text.Length==0){
				Destroy(gameObject);
			}

		} else {
			Destroy(gameObject);
		}


	}
}
