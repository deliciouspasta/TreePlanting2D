using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewController : MonoBehaviour {

	static GameObject sv;
	static GameObject svh;
	
	
	void Start () {

		//スクロールを非表示にしておく
		sv = GameObject.Find("ScrollView");
		sv.SetActive(false);

		svh = GameObject.Find("Scroll View Human");
		svh.SetActive(false);

		
	}
	

	//StaticRockerに入れずにtrue,falseの切り替えを行なう
	public static void SVSetActiver(bool b){
		sv.SetActive(b);
	}
	
	public static void SVHSetActiver(bool b){
		svh.SetActive(b);
	}

	
	
}
