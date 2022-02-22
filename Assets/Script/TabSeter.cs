using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSeter : MonoBehaviour {

	static GameObject TabHolding;
	GameObject _camera;
	Vector3 cameraPos;

	void Start () {
		
		
		TabHolding = GameObject.Find("TabHolding");

		//タブの位置を正しい場所に置く
		this._camera = StaticRocker._camera;
		this.cameraPos = this._camera.transform.position;
		StaticRocker.tab1.transform.position = this.cameraPos;
		StaticRocker.tab2.transform.position = this.cameraPos;
		StaticRocker.tab3.transform.position = this.cameraPos;
		StaticRocker.tab4.transform.position = this.cameraPos;
		StaticRocker.tabA1.transform.position = this.cameraPos;
		StaticRocker.tabA2.transform.position = this.cameraPos;
		

		StaticRocker.tab1.transform.Translate(-2.2f,1.05f,10);
		StaticRocker.tab2.transform.Translate(-2.2f,1.05f,10);
		StaticRocker.tab3.transform.Translate(-2.2f,1.05f,10);
		StaticRocker.tab4.transform.Translate(-2.2f,1.05f,10);
		StaticRocker.tabA1.transform.Translate(-2.2f,1.05f,10);
		StaticRocker.tabA2.transform.Translate(-2.2f,1.05f,10);

		//タブを見えなくする
		StaticRocker.tab1.SetActive(false);
		StaticRocker.tab2.SetActive(false);
		StaticRocker.tab3.SetActive(false);
		StaticRocker.tab4.SetActive(false);
		StaticRocker.tabA1.SetActive(false);
		StaticRocker.tabA2.SetActive(false);
	}


	public static void SetActiver(string name, bool b){
		foreach(Transform child in TabHolding.transform){
			if(child.name == name){
				child.gameObject.SetActive(b);
				return;
			}
		}
		Debug.LogWarning("NOT FOUND" + name);
	}

	//ズームしたときのタブを適切な位置に設定する
	public static void TabMover(){
		Vector3 _cameraPos;
		_cameraPos = StaticRocker._camera.transform.position;


		
		StaticRocker.tab1.transform.position = _cameraPos;
		StaticRocker.tab2.transform.position = _cameraPos;
		StaticRocker.tab3.transform.position = _cameraPos;
		StaticRocker.tab4.transform.position = _cameraPos;
		StaticRocker.tabA1.transform.position = _cameraPos;
		StaticRocker.tabA2.transform.position = _cameraPos;


		StaticRocker.tab1.transform.Translate(0.5f,0,10);
		StaticRocker.tab2.transform.Translate(0.5f,0,10);
		StaticRocker.tab3.transform.Translate(0.5f,0,10);
		StaticRocker.tab4.transform.Translate(0.5f,0,10);
		StaticRocker.tabA1.transform.Translate(0.5f,0,10);
		StaticRocker.tabA2.transform.Translate(0.5f,0,10);

		StaticRocker.treeHolding.transform.position = _cameraPos;
		StaticRocker.humanHolding.transform.position = _cameraPos;

		StaticRocker.treeHolding.transform.Translate(2.4f,-0.7f,10);
		StaticRocker.humanHolding.transform.Translate(-2.5f,-0.2f,10);


		
	}
}
