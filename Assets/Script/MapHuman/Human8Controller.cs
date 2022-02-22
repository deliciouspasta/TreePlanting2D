using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human8Controller : MonoBehaviour {

	//この人材の番号
	private int n = 8;

	//残りのアイテムの数をひょうじするためのUI 
	void Start(){
		StaticRocker.allHumanNumberUI[n] = transform.GetChild(0).gameObject;
	}

	public void OnClicking(){
		ScrollViewButtonController.ItemTab3to4();
		ScrollViewController.SVHSetActiver(false);

		MyButton.SetActiver("YesButton",true);
		MyButton.SetActiver("NoButton",true);
		MyButton.SetActiver("TabButtonBack",false);


		//選択した人を確認画面で表示
		StaticRocker.humanItem[n].SetActive(true);

		//現在の番号をこの人の番号にする
		StaticRocker.selectedHuman = n;


		StaticRocker.HumanInfo tempHumanInfo = new StaticRocker.HumanInfo();


		//構造体に代入するのだが変数を途中で削ったため一つしかない
		tempHumanInfo.plantSpeed = 1500000;
		
		

		//human nの情報をクリックされたスクエアのヒューマン箱（StaticRocker.humanInfo[n]）に格納する
		for(int i = 0; i < 200; i++){
			if(StaticRocker.isSquareBool[i] == true){
				StaticRocker.humanInfo[i] = tempHumanInfo;
			}
		}

		
	}
}
