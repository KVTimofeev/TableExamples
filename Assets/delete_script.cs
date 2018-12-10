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
			string str = txtOnAnswer.text;
			char lastSimb=str[str.Length-1];
			GameObject simb=GameObject.Find(lastSimb+"");
			manageLev manager = (manageLev)GameObject.Find(tables.Managerlevel).GetComponent<manageLev>() as manageLev;
			manager.DoItVisible(simb);
			txtOnAnswer.text = txtOnAnswer.text.Remove (txtOnAnswer.text.Length - 1);
			if(txtOnAnswer.text.Length==0){
				Destroy(gameObject);
			}

		} else {
			Destroy(gameObject);
		}


	}
}
