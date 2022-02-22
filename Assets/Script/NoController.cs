using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoController : MonoBehaviour {

		
	public void NoClicked(){
		if(StaticRocker.tabNumber == 1){
			StaticRocker.tab1.SetActive(false);
			MyButton.SetActiver("TabButtonBack",false);
			MyButton.SetActiver("BackButton",true);
			MyButton.SetActiver("YesButton",false);
			MyButton.SetActiver("NoButton",false);
			StaticRocker.tabNumber = 0;
			CameraController.isGoneTabFlag = false;

			//植林手続き中ではなくなる
			StaticRocker.isSquareBool[StaticRocker.NowSquareNumber] = false;
			//現在選択されているスクエア番号を存在しない値にする。
			StaticRocker.NowSquareNumber = 999;
			


			//どのスクエアでもクリック可能にする
			StaticRocker.isCanSquareClick = true;

		}

// 最後の確認画面でのNO
		if(StaticRocker.tabNumber == 4){
			StaticRocker.tab4.SetActive(false);
			StaticRocker.tab3.SetActive(true);
			MyButton.SetActiver("TabButtonBack",true);
			MyButton.SetActiver("YesButton",false);
			MyButton.SetActiver("NoButton",false);
			ScrollViewController.SVHSetActiver(true);
			StaticRocker.tabNumber = 3;

			//確認画面に表示される選択した人を非表示にする
			StaticRocker.humanItem[StaticRocker.selectedHuman].SetActive(false);
			StaticRocker.selectedHuman = 0;
		}


		//売却の最終確認を取り消す。
		if(StaticRocker.tabANumber == 2){
			
			StaticRocker.tabA2.SetActive(false);
			StaticRocker.tabA1.SetActive(true);
			StaticRocker.tabANumber = 1;
			MyButton.SetActiver("UruButton",true);
			MyButton.SetActiver("YesButton",false);
			MyButton.SetActiver("NoButton",false);
			MyButton.SetActiver("TabButtonBack",true);
		}
	}
}
