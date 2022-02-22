using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UruButtonController : MonoBehaviour {

	public void UruClicked(){
		//売却ボタンを押されることで確認画面に移る。1から2
		if(StaticRocker.tabANumber == 1){
			StaticRocker.tabA1.SetActive(false);
			StaticRocker.tabA2.SetActive(true);

			MyButton.SetActiver("UruButton",false);
			MyButton.SetActiver("TabButtonBack",false);
			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);

			StaticRocker.tabANumber = 2;
		}
	}
}
