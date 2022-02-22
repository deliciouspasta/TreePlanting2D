using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveOKController : MonoBehaviour {

	public void OnClicked(){
		//開発済みフラグを立てる
		StaticRocker.isDeved[DeveStatic.NowDeveItemNumber] = true;

		//開発終了しましたタブを非表示
		DeveStatic.deveFinTab.SetActive(false);

		DeveMyButton.DeveSetActiver("DeveOKButton",false);

		

		//この研究所の番号の開発可能ホルダーを表示する。
		DeveMyButton.DeveSetActiver("Labo"+DeveStatic.NowLaboNumber.ToString()+"CanHolder",true);

		//開発により延べ棒が減った後でも所持している延べ棒の数が開発費を上回っていたらボタンを反応可能にする
		DeveActiveDirector.ActiveItemChecker();

		//現在のアイテムの開発番号を０にする
		DeveStatic.NowDeveItemNumber = 0;

		//現在のタブ番号を変更
		DeveStatic.NowDeveTabNumber = 1;
	}
}
