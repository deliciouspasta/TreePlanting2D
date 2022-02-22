using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewHumanButtonController : MonoBehaviour {

	/*static GameObject _canvas;
	static GameObject looking;
	static GameObject looking2;
	static GameObject looking3;
	Transform content;
	*/
	
	static GameObject content;
	void Start () {
		/*_canvas = GameObject.Find("Canvas");
		looking = _canvas.transform.Find("ScrollView").gameObject;
		looking2 = looking.transform.Find("Viewport").gameObject;
		looking3 = looking2.transform.Find("Content").gameObject;
		if(looking != null){
			Debug.Log("looking NULL");
		}
		if(looking2 != null){
			Debug.Log("looking2 NULL");
		}
		if(looking3 != null){
			Debug.Log("looking3 NULL");
		}
		*/
		content = this.gameObject;
		Debug.Log(content);
		
	}
	
	

	public static void SetScrollActiver(string name, bool b){
		foreach(Transform child in content.transform){
			if(child.name == name){
				child.gameObject.SetActive(b);
				return;
			}
		}
	}

	// tree系統のアイテムをタップしたらタブを２から３に移動させる
	public static void ItemTab2to3(){
		StaticRocker.tab2.SetActive(false);
		StaticRocker.tab3.SetActive(true);
		StaticRocker.tabNumber = 3;
	}
	// human系統のアイテムをタップしたらタブを３から４に移動させる
	public static void ItemTab3to4(){
		StaticRocker.tab3.SetActive(false);
		StaticRocker.tab4.SetActive(true);
		MyButton.SetActiver("BackButton",false);
		
		StaticRocker.tabNumber = 4;
	}

	
}

