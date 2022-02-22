using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//このスクリプトを最初に実行して優先的にCanvasの全容を知らせないと後から追加されたCanvas上のオブジェクトが別のクラスで呼び出されたときにNullPoしてしまう
public class MyButton : MonoBehaviour {

	static Canvas _canvas;
	

	void Start(){
		_canvas = GetComponent<Canvas>();
	}

	public static void SetActiver(string name , bool b){
		foreach(Transform child in _canvas.transform){
			if(child.name == name){
				child.gameObject.SetActive(b);
				return;
			}
		}
		Debug.LogWarning("NOT FOUND"+ name);
	}

	//ボタンを半透明にする、戻す
	/*public static void Interactabler(string name , bool b){
		foreach(Transform child in thiscontent.transform){
			Debug.Log(child.name);
			if(child.gameObject.tag == "SaleButton"){
				Debug.Log("Tag Clear");
				if(child.name == name){
					Button btn = child.GetComponent<Button>();
					btn.interactable = b;
					Debug.Log("SaleButton interra");
					return;
				}
			}

			
		}
	}*/
}
