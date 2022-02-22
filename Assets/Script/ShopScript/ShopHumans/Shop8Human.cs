using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop8Human : MonoBehaviour {

	Coroutine PressCorutine;
	bool isPressDown = false;
	bool isPressUp = true;
	float PressTime = 0.3f;




    //このヒトがの１００万本植えるときの人件費
	long thisHumanPriceRainbow = 3;

	
	
	
	public void OnClicking(){

		if(isPressDown){
			isPressDown = false;
			isPressUp = true;
		}


		if(isPressUp == true){
			
			
			//確認画面でヒトの画像を表示する
			ShopStatic.shopHuman[8].SetActive(true);

			//延べ棒で支払い
			ShopStatic.isRainbow = true;

			//買い取り値にこのヒトの値段を代入する
			ShopStatic.nowHumanPriceRainbow = thisHumanPriceRainbow;

	
			//まっさら（長押し説明）タブを非表示にし、確認タブを表示
			ShopStatic.longPushTab.SetActive(false);
			ShopStatic.confirmTab.SetActive(true);
			ShopStatic.shopNowTabNumber = 2;

			//Yes,Noボタンを表示
			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);

			//スクロールを非表示
			ShopSVController.SaleHumanSetActiver(false);

			
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

			//現在のヒトの日誌番号
			ShopStatic.shopNowDiaryHumanNumber = 8;

			//日誌を表示、背景タブを表示
			ShopStatic.shopHumanExplainTab[8].SetActive(true);
			ShopStatic.backImageDiary.SetActive(true);

			//長押し説明タブとヒトのスクロールを非表示
			ShopStatic.longPushTab.SetActive(false);
			ShopSVController.SaleHumanSetActiver(false);

			//ヒトの日誌フラグをtrueにする
			ShopStatic.isHumanDiary = true;

			//現在のタブ番号を存在しない番号にする
			ShopStatic.shopNowTabNumber = -1;

			//UIを非表示
			ShopStatic.ShopCoinObject.SetActive(false);
			ShopStatic.ShopRainbowObject.SetActive(false);


			isPressUp = false;
		}

		isPressDown = false;
	}




}
