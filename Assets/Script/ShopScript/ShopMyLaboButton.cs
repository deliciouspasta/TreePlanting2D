using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopMyLaboButton : MonoBehaviour {


	static GameObject thiscontentLabo;
	void Start (){
		thiscontentLabo = this.gameObject;
		
	}

	//ボタンの半透明の管理
	public static void InteractablerLabo(string name , bool b){
		foreach(Transform child in thiscontentLabo.transform){
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
