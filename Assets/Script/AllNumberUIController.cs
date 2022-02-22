using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllNumberUIController : MonoBehaviour {

	//アイテムのスタック数を表示
	public static void AllNumberTreeDisplayUI(){
		for(int i = 1; i < 14; i++){

			if(StaticRocker.isTree[i]){
				Text textUI = StaticRocker.allTreeNumberUI[i].GetComponent<Text>();
				textUI.text = "× " + StaticRocker.allTree[i];
			}
		}	
	}

	public static void AllNumberHumanDisplayUI(){
		for(int i = 1; i < 14; i++){

			if(StaticRocker.isHuman[i]){
				Text textUI = StaticRocker.allHumanNumberUI[i].GetComponent<Text>();
				textUI.text = "× " + StaticRocker.allHuman[i];
			}
		}	
	}


	
}
