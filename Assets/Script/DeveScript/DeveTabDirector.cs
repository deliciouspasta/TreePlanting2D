using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeveTabDirector : MonoBehaviour {

	public void DeveTabBacker(){
		if(DeveStatic.NowDeveTabNumber == 0){

			SceneManager.LoadScene("MapScene");

		}else if(DeveStatic.NowDeveTabNumber == 1){


			//現在の研究所の番号の開発可能ホルダーを非表示にする。
			DeveMyButton.DeveSetActiver("Labo"+DeveStatic.NowLaboNumber.ToString()+"CanHolder",false);

			//隅にあった研究所の画像を非表示
			DeveStatic.deveLabo[DeveStatic.NowLaboNumber].SetActive(false);

			//最初の研究所群を表示
			DeveMyButton.DeveSetActiver("DeveLaboButtonHolder",true);

			//現在の研究所番号を０に戻す
			DeveStatic.NowLaboNumber = 0;

			//現在のタブ番号を変更
			DeveStatic.NowDeveTabNumber = 0;
			

		}else if(DeveStatic.NowDeveTabNumber == 2){

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

		}else if(DeveStatic.isLaboExplain){
			//現在の研究所説明タブを非表示
			DeveStatic.deveLaboExplain[DeveStatic.NowLaboExplainNumber].SetActive(false);

			//最初の研究所群を表示
			DeveMyButton.DeveSetActiver("DeveLaboButtonHolder",true);

			//UIを表示
			DeveStatic.DeveRainbowObject.SetActive(true);

			DeveStatic.isLaboExplain = false;

			//タブ番号も正しいものに戻す
			DeveStatic.NowDeveTabNumber = 0;
		}
	}
}
