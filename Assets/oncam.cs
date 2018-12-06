using UnityEngine;
using System.Collections;

public class oncam : MonoBehaviour {
	public Sprite[] PictureGo;
	public Sprite current;
	public GameObject kvadrat;
	public GameObject Okno_calc;
	public GameObject simbol;
	int currentIndexQuest=0;
	// Use this for initialization
	void Start () {
		if (tables.PictureGo == null) {
			tables.PictureGo = PictureGo;
			tables.currentQuestIndex = 0;
			tables.answers_PicturesGo = new string[]{"домик","пустыня","коала","пингвины"};
			//current=PictureGo[currentIndexQuest];


		} else {
			//Debug.Log("zoom "+currentIndexQuest);
			tables.currentQuestIndex++;


		}
		SpriteRenderer currentFon = (SpriteRenderer)GameObject.Find ("current_fon").GetComponent<SpriteRenderer>() as SpriteRenderer;
		current=PictureGo[tables.currentQuestIndex];
		currentFon.sprite = current;
		currentIndexQuest = tables.currentQuestIndex;

		okno_calc ();
		float float_x = -7.5f;
		float float_y = 4f;
		int i = 1;
		tables.countSquares = 0;
		while (float_y>0f) {
			while (float_x<0) {
				tables.countSquares++;
			GameObject go = Instantiate (kvadrat) as GameObject;
			go.transform.position = new Vector2 (float_x, float_y);
				TextMesh txtOnKvadratik=(TextMesh)go.GetComponentInChildren<TextMesh>() as TextMesh;
				txtOnKvadratik.text=create_example();
				go.name="sc="+i;
				//go.tag="square";
			i++;
			float_x += 2f;
			}
			float_x=-7.5f;
			float_y-=1;
		}

		okno_enter_answer ();
	}
	string create_example(){
		int a = Random.Range (1,9);
		int b = Random.Range (1, 9);
		return a + "+" + b;
	}

	void okno_calc(){
		float float_x = Okno_calc.transform.position.x;
		float float_y = Okno_calc.transform.position.y;
		Okno_calc.transform.position = new Vector3 (float_x, float_y, tables.zone_unvisible_z);
		}

	void okno_enter_answer(){
		float bukv_x = -8f;
		float bukv_y = -1.3f;
		//string str="slovo";
		tables.answer_current_fon = tables.answers_PicturesGo[currentIndexQuest];

		string str = tables.answer_current_fon;
		///
		str = Shuffle (str);
		int str_len = str.Length;
		while (str_len>0) {
			GameObject simb = Instantiate (simbol) as GameObject;
			simb.transform.position = new Vector3 (bukv_x,bukv_y,tables.zone_visible_z);
			simb.transform.parent=GameObject.Find ("picter_answered_wind").transform;
			TextMesh charSimb=simb.GetComponentInChildren<TextMesh>() as TextMesh;

			charSimb.text=str[str_len-1]+"";
			simb.name=charSimb+"";
			str_len--;
			bukv_x+=1.5f;
			}
		}



	public string Shuffle(string str)
	{
		char[] array = str.ToCharArray();
		//Random rng = new Random();
		int n = array.Length;
		while (n > 1)
		{
			n--;
			int k = Random.Range(0,n + 1);
			var value = array[k];
			array[k] = array[n];
			array[n] = value;
		}
		return new string(array);
	}

	string slivki(string str){
		int lastSimb = str.Length-1;
		while (lastSimb>=0) {

			try{

				int r=Random.Range(0,lastSimb);
				char temp=str[r];


				str=str.Remove(r,1);

					


				str=str.Insert(r,str[lastSimb]+"");
				//str[r]=str[lastSimb];
				//str[lastSimb]=temp;

					

				str=str.Remove(lastSimb,1);
					

				
				str=str.Insert(lastSimb,temp+"");
				Debug.Log(str+" "+lastSimb);
				lastSimb--;

			}catch{
				Debug.Log("ArgumentOutOfRange "+lastSimb);
				return "";
			}

		}
		return str;
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
