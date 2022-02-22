using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTree3 : MonoBehaviour {

	Coroutine PressCorutine;
	bool isPressDown = false;
	bool isPressUp = true;
	float PressTime = 0.3f;


    //この木の１００万本の値段
	long thisTreePrice = 77000000;

	
	
	
	public void OnClicking(){

		if(isPressDown){
			isPressDown = false;
			isPressUp = true;
		}


		if(isPressUp == true){

			//確認画面で木の画像を表示する
			ShopStatic.shopTree[3].SetActive(true);

			//コインで支払い
			ShopStatic.isCoin = true;

			//買い取り値にこの木の値段を代入する
			ShopStatic.nowTreePrice = thisTreePrice;

	
			//まっさら（長押し説明）タブを非表示にし、確認タブを表示
			ShopStatic.longPushTab.SetActive(false);
			ShopStatic.confirmTab.SetActive(true);
			ShopStatic.shopNowTabNumber = 2;

			//Yes,Noボタンを表示
			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);

			//スクロールを非表示
			ShopSVController.SaleTreeSetActiver(false);
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

			//現在の木の日誌番号
			ShopStatic.shopNowDiaryTreeNumber = 3;

			//日誌を表示、背景タブを表示
			ShopStatic.shopTreeExplainTab[3].SetActive(true);
			ShopStatic.backImageDiary.SetActive(true);

			//長押し説明タブと木のスクロールを非表示
			ShopStatic.longPushTab.SetActive(false);
			ShopSVController.SaleTreeSetActiver(false);

			//木の日誌フラグをtrueにする
			ShopStatic.isTreeDiary = true;

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
