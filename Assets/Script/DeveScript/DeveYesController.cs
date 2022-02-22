using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveYesController : MonoBehaviour {


	//開発しますか？
	public void OnClicked(){
		//所持している虹の延べ棒の数を選択されているアイテムの開発費ぶんだけ引く
		StaticRocker.RainbowHolder -= DeveStatic.deveTable[DeveStatic.NowDeveItemNumber];


		//虹の延べ棒残高を表示
		DeveUIController.DeveDisplayRainbowUI();

		//開発終了タブを表示、確認タブを非表示
		DeveStatic.deveFinTab.SetActive(true);
		DeveStatic.deveComfirmTab.SetActive(false);


		DeveMyButton.DeveSetActiver("DeveYesButton",false);
		DeveMyButton.DeveSetActiver("DeveNoButton",false);

		//OKボタンを表示
		DeveMyButton.DeveSetActiver("DeveOKButton",true);

		//選択された開発アイテムの画像を非表示
		DeveStatic.deveItem[DeveStatic.NowDeveItemNumber].SetActive(false);

		//現在のタブ番号を変更
		DeveStatic.NowDeveTabNumber = 3;

		
	}
}
