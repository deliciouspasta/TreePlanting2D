using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveNoController : MonoBehaviour {

	public void OnClicked(){

		//確認タブを閉じる
		DeveStatic.deveComfirmTab.SetActive(false);

		DeveMyButton.DeveSetActiver("DeveYesButton",false);
		DeveMyButton.DeveSetActiver("DeveNoButton",false);

		//選択された開発アイテムの画像を非表示
		DeveStatic.deveItem[DeveStatic.NowDeveItemNumber].SetActive(false);

		//この研究所の番号の開発可能ホルダーを表示する。
		DeveMyButton.DeveSetActiver("Labo"+DeveStatic.NowLaboNumber.ToString()+"CanHolder",true);

		//現在のアイテムの開発番号を０に戻す
		DeveStatic.NowDeveItemNumber = 0;

		//現在のタブ番号を変更
		DeveStatic.NowDeveTabNumber = 1;
	}
}
