using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopMyHumanButton : MonoBehaviour {


	static GameObject thiscontent;
	void Start (){
		thiscontent = this.gameObject;
	}

	//ボタンの半透明の管理
	public static void Interactabler(string name , bool b){
		foreach(Transform child in thiscontent.transform){
			Debug.Log(child.name);
			
			
			if(child.name == name){
				Button btn = child.GetComponent<Button>();
				btn.interactable = b;

				EventTrigger et = child.GetComponent<EventTrigger>();
				et.enabled = b;
				Debug.Log("SaleButton interra");
				return;
			}
			

			
		}
	}
}
