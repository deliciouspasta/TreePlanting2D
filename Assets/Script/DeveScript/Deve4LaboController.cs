using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deve4LaboController : MonoBehaviour {

	Coroutine PressCorutine;
	bool isPressDown = false;
	bool isPressUp = true;
	float PressTime = 0.3f;

	//このスクリプト唯一の固有の値（あとはほかのスクリプトとクラス名以外は全く同じ）
	int labon = 4;
	
	public void OnClicked(){

		if(isPressDown){
			isPressDown = false;
			isPressUp = true;
		}

		//クリックされたときの処理
		if(isPressUp == true){
			//この研究所の画像を隅に表示
			DeveStatic.deveLabo[labon].SetActive(true);
		
			//この研究所の番号の開発可能ホルダーを表示する。
			DeveMyButton.DeveSetActiver("Labo"+labon.ToString()+"CanHolder",true);

			//最初の研究所群を非表示
			DeveMyButton.DeveSetActiver("DeveLaboButtonHolder",false);

			//現在の研究所番号をこのスクリプトの研究所番号にする。
			DeveStatic.NowLaboNumber = labon;

			//所持している延べ棒の数が開発費を上回っていたらボタンを反応可能にする
			DeveActiveDirector.ActiveItemChecker();

			//現在のタブ番号を変更
			DeveStatic.NowDeveTabNumber = 1;
		}
		
	}

	public void LongPushed(){
		if(PressCorutine!= null){
			StopCoroutine(PressCorutine);
		}
		PressCorutine = StartCoroutine(TimeForPointerDown());
	}

	public IEnumerator TimeForPointerDown(){
		isPressDown = true;

		yield return new WaitForSeconds(PressTime);

		//長押し成功時にする処理
		if(isPressDown){
			Debug.Log("長押し成功！！！やったーーー");

			//現在の研究所の 説明　番号
			DeveStatic.NowLaboExplainNumber = labon;

			//日誌（便宜）を表示
			DeveStatic.deveLaboExplain[labon].SetActive(true);
			

			//研究所群を非表示
			DeveMyButton.DeveSetActiver("DeveLaboButtonHolder",false);


			//現在のタブ番号を存在しない番号にする
			DeveStatic.NowDeveTabNumber = -1;

			//UIを非表示
			DeveStatic.DeveRainbowObject.SetActive(false);

			//研究所の説明フラグを立てる
			DeveStatic.isLaboExplain = true;

			isPressUp = false;
		}

		isPressDown = false;
	}
}
