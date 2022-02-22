using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabDirector : MonoBehaviour {

	GameObject tab1;
	// Use this for initialization
	void Start () {
		tab1 = StaticRocker.tab1;
	}
	
	

	public void TabBacker(){
		if(StaticRocker.tabNumber == 1){
			tab1.SetActive(false);
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

		if(StaticRocker.tabNumber == 2){
			StaticRocker.tab1.SetActive(true);
			StaticRocker.tab2.SetActive(false);
			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);
			ScrollViewController.SVSetActiver(false);
			StaticRocker.tabNumber = 1;
			//購入を促す画像は非表示にする
			StaticRocker.pleaseBuyImage.SetActive(false);
		}
// 人間の選択から木の選択に戻る
		if(StaticRocker.tabNumber == 3){
			StaticRocker.tab2.SetActive(true);
			StaticRocker.tab3.SetActive(false);
			ScrollViewController.SVHSetActiver(false);
			ScrollViewController.SVSetActiver(true);
			StaticRocker.tabNumber = 2;

			//確認画面に表示される選択した木を非表示にする
			StaticRocker.treeItem[StaticRocker.selectedTree].SetActive(false);
			StaticRocker.selectedTree = 0;
			//購入を促す画像は非表示にする
			StaticRocker.pleaseBuyImage.SetActive(false);
		}

		//植林手続き後、スクエアを一度クリックしたときに出るタブからタブなしの画面に戻る。ここでUIの非表示もしないといけない。
		if(StaticRocker.tabANumber == 1){
			for(int i = 0; i < 200; i++){
				if(StaticRocker.isSellSquare[i] == true){
					StaticRocker.isSellSquare[i] = false;
			
					StaticRocker.tabA1.SetActive(false);

					//UIの非表示
					StaticRocker.treeAmount.SetActive(false);
					StaticRocker.nowcointreeUI.SetActive(false);

					//確認用の木の画像の非表示
					StaticRocker.treeItem[StaticRocker.selectedTreeS[i]].SetActive(false);

					StaticRocker.tabANumber = 0;
					MyButton.SetActiver("TabButtonBack",false);
					MyButton.SetActiver("BackButton", true);
					MyButton.SetActiver("UruButton",false);
					CameraController.isGoneTabFlag = false;
					//どのスクエアでもクリック可能にする
					StaticRocker.isCanSquareClick = true;
					break;
				
				}

			}
		}
	} 

	
}
