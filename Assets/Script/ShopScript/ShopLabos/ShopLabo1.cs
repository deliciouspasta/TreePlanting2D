using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopLabo1 : MonoBehaviour {

	Coroutine PressCorutine;
	bool isPressDown = false;
	bool isPressUp = true;
	float PressTime = 0.3f;




    //この研究所の買い取り値段
	long thisLaboPriceRainbow = 3;

	
	
	
	public void OnClicking(){

		if(isPressDown){
			isPressDown = false;
			isPressUp = true;
		}


		if(isPressUp == true){
			
			
			//確認画面で研究所の画像を表示する
			ShopStatic.shopLabo[1].SetActive(true);

			//延べ棒で支払い
			ShopStatic.isRainbow = true;

			//買い取り値にこのヒトの値段を代入する
			ShopStatic.nowLaboPriceRainbow = thisLaboPriceRainbow;

	
			//まっさら（長押し説明）タブを非表示にし、確認タブを表示
			ShopStatic.longPushTab.SetActive(false);
			ShopStatic.confirmTab.SetActive(true);
			ShopStatic.shopNowTabNumber = 2;

			//Yes,Noボタンを表示
			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);

			//スクロールを非表示
			ShopSVController.SaleLaboSetActiver(false);

			//現在選択されている研究所の番号を代入
			ShopStatic.shopSelectedLabo = 1;

			
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

		//長押し成功時似する処理
		if(isPressDown){
			Debug.Log("長押し成功！！！やったーーー");

			//現在の研究所の日誌番号
			ShopStatic.shopNowDiaryLaboNumber = 1;

			//日誌（便宜）を表示、背景タブを表示
			ShopStatic.shopLaboExplainTab[1].SetActive(true);
			ShopStatic.backImageDiary.SetActive(true);

			//長押し説明タブと研究所のスクロールを非表示
			ShopStatic.longPushTab.SetActive(false);
			ShopSVController.SaleLaboSetActiver(false);


			//現在のタブ番号を存在しない番号にする
			ShopStatic.shopNowTabNumber = -1;

			//UIを非表示
			ShopStatic.ShopCoinObject.SetActive(false);
			ShopStatic.ShopRainbowObject.SetActive(false);

			//研究所の日誌フラグを立てる
			ShopStatic.isLaboDiary = true;

			isPressUp = false;
		}

		isPressDown = false;
	}




}
