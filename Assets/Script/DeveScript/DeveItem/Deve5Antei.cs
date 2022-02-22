using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deve5Antei : MonoBehaviour {

	//このスクリプト唯一の固有の値
	int n = 11;

	//「開発済み」画像を格納し、非表示にする
	void Start(){
		DeveStatic.devedIgames[n] = transform.GetChild(1).gameObject;
		DeveStatic.devedIgames[n].SetActive(false);
	}

	public void OnClicked(){
		//開発しますか？の確認タブを開く
		DeveStatic.deveComfirmTab.SetActive(true);

		DeveMyButton.DeveSetActiver("DeveYesButton",true);
		DeveMyButton.DeveSetActiver("DeveNoButton",true);

		//選択された開発アイテムの画像を表示
		DeveStatic.deveItem[n].SetActive(true);

		//現在の開発番号をこのスクリプトの開発番号にする。
		DeveStatic.NowDeveItemNumber = n;

		//この研究所の番号の開発可能ホルダーを非表示にする。
		DeveMyButton.DeveSetActiver("Labo"+DeveStatic.NowLaboNumber.ToString()+"CanHolder",false);

		//現在のタブ番号を変更
		DeveStatic.NowDeveTabNumber = 2;

	}
}
