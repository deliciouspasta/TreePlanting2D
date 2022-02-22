using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DeveMyButton : MonoBehaviour {

	static Canvas _canvas;
	static GameObject deveLaboButtonHolder;

	void Start(){
		_canvas = GetComponent<Canvas>();
		deveLaboButtonHolder = GameObject.Find("DeveLaboButtonHolder");
	}

	//Canvas上のコンテンツの表示、非表示を管理
	public static void DeveSetActiver(string name, bool b){
		foreach(Transform child in _canvas.transform){
			if(child.name == name){
				child.gameObject.SetActive(b);
				return;
			}
		}
		Debug.Log("notFound");
	}

	//ボタンの半透明の管理
	public static void DeveInteractablerLabo(string name , bool b){

	
		GameObject thisObject = DeveStatic.laboCanHolders[DeveStatic.NowLaboNumber];

		foreach(Transform child in thisObject.transform){
			Debug.Log(child.name);
			
			//開発費が足りないならボタンを半透明にする
			if(child.name == name){
				Button btn = child.GetComponent<Button>();
				btn.interactable = b;
	
				Debug.Log("DeveButton interra");
				return;
			}
		}		
	}

	//研究所群のボタンの半透明の管理
	public static void DeveInteractablerLaboSelf(string name, bool b){

		foreach(Transform child in deveLaboButtonHolder.transform){
			if(child.name == name){
				Button btn = child.GetComponent<Button>();
				btn.interactable = b;

				EventTrigger et = child.GetComponent<EventTrigger>();
				et.enabled = b;
	
				Debug.Log("DeveButton interra");
				return;
			}

			Debug.Log("DeveLaboNotFound");
		}
	}
}
