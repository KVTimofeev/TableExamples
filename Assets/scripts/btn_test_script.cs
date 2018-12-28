using UnityEngine;
using System.Collections;

public class btn_test_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		int enter_ans = int.Parse (tables.enter_answer);

		if (enter_ans == tables.answer) {
			GameObject square=GameObject.Find(tables.str_id);
			GameObject okno_calc = GameObject.Find ("okno_calc");
			float x=okno_calc.transform.position.x;
			float y=okno_calc.transform.position.y;
			okno_calc.transform.position=new Vector3(x,y,tables.zone_unvisible_z);
			//okno_calc.activeInHierarchy=false;
			tables.enter_answer="";
			tables.answer=0;
			Destroy(square);
			tables.countSquares--;
			if(tables.countSquares<1){
				manageLev manager=GameObject.Find("ManagerLevel").GetComponent<manageLev>();
				manager.EndLevel();
			}
			Debug.Log ("верно");
		} else {
			Debug.Log("neverno");
		}

	}
}
