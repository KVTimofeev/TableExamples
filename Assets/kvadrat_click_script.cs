using UnityEngine;
using System.Collections;

public class kvadrat_click_script : MonoBehaviour {
	public GameObject okno_calc;

	// Use this for initialization
	void Start () {
		okno_calc = GameObject.Find ("okno_calc");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		tables.str_id = gameObject.name;
		float float_x_calc_wind = okno_calc.transform.position.x;
		float float_y_calc_wind = okno_calc.transform.position.y;
		okno_calc.transform.position = new Vector3 (float_x_calc_wind, float_y_calc_wind, tables.zone_visible_z);
		TextMesh txtOnSolutOkno = (TextMesh)okno_calc.GetComponentInChildren<TextMesh> () as TextMesh;
		TextMesh txtOnKvadradic = (TextMesh)gameObject.GetComponentInChildren<TextMesh> () as TextMesh;
		txtOnSolutOkno.text = txtOnKvadradic.text+"=";
		Parser p = new Parser (txtOnKvadradic.text);
	}
}
