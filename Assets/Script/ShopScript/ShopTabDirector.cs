using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopTabDirector : MonoBehaviour {

	
	void Start () {
		
	}
	
	public void ShopTabBacker(){

		//最初の４つのボタンからMapSceneに戻る。
		if(ShopStatic.shopNowTabNumber == 0){
			SceneManager.LoadScene("MapScene");
		}




		//木のスクロールでの最初の４つのボタンの画面に戻る
		if(ShopStatic.shopNowTabNumber == 1){

			//最初に表示されている４つのボタンを 表示する
			MyButton.SetActiver("ShopTree",true);
			MyButton.SetActiver("ShopHuman",true);
			MyButton.SetActiver("ShopLabo",true);
			MyButton.SetActiver("ShopCoinToBar",true);

			//木のスクロールを非表示にする
			ShopSVController.SaleTreeSetActiver(false);
			//人材のスクロールを非表示にする
			ShopSVController.SaleHumanSetActiver(false);

			//研究所のスクロールを非表示にする
			ShopSVController.SaleLaboSetActiver(false);

			//トレード画面の時
			if(ShopStatic.shopTabNumber == 4){
				//前のタブやUIなど不必要なものを非表示
				ShopStatic.tradeExplainTab.SetActive(false);
				ShopStatic.TradeRainbowObject.SetActive(false);
				ShopStatic.TradeVirtualCoinObject.SetActive(false);
				ShopStatic.tradeImage.SetActive(false);
				MyButton.SetActiver("TradeButton",false);
				MyButton.SetActiver("TriUpButtonDirector",false);
				MyButton.SetActiver("TriDownButtonDirector",false);
			}

			ShopStatic.longPushTab.SetActive(false);
			ShopStatic.shopTabNumber = 0;
			ShopStatic.shopNowTabNumber = 0;
		}


		//木や人材、研究所の購入の確認画面での　戻る
		if(ShopStatic.shopNowTabNumber == 2){

			//確認タブとYes,Noボタンを非表示にし、長押しタブを表示。スクロールを 表示

			MyButton.SetActiver("YesButton", false);
			MyButton.SetActiver("NoButton", false);


			ShopStatic.confirmTab.SetActive(false);

			ShopStatic.longPushTab.SetActive(true);

			ShopStatic.shopNowTabNumber = 1;



				//木のボタンを選択していた場合
			if(ShopStatic.shopTabNumber == 1){

				ShopSVController.SaleTreeSetActiver(true);

				//確認画面での木の画像を非表示
			  for(int i = 1; i < 14; i++){
					ShopStatic.shopTree[i].SetActive(false);
				}

			}else if(ShopStatic.shopTabNumber == 2){
				//人材のボタンを選択していた場合

				ShopSVController.SaleHumanSetActiver(true);

				//確認画面での木の画像を非表示
			  for(int i = 1; i < 14; i++){
					ShopStatic.shopHuman[i].SetActive(false);
				}
				
			}else if(ShopStatic.shopTabNumber == 3){
				//研究所のボタンを選択していた場合
				ShopSVController.SaleLaboSetActiver(true);

				//確認画面での研究所の画像を非表示
				for(int i = 1; i < 6; i++){
					ShopStatic.shopLabo[i].SetActive(false);
				}

				//現在選択されている研究所の番号を０に戻す
				ShopStatic.shopSelectedLabo = 0;

			}else if(ShopStatic.shopTabNumber == 4){
				//交換のボタンを選択していた場合

				//トレードしてよろしいですかタブを閉じる
				ShopStatic.tradeTab.SetActive(false);

				//前のタブやUIなど必要なものを表示
				ShopStatic.tradeExplainTab.SetActive(true);
				ShopStatic.TradeRainbowObject.SetActive(true);
				ShopStatic.TradeVirtualCoinObject.SetActive(true);
				ShopStatic.tradeImage.SetActive(true);
				MyButton.SetActiver("TradeButton",true);
				MyButton.SetActiver("TriUpButtonDirector",true);
				MyButton.SetActiver("TriDownButtonDirector",true);


				MyButton.SetActiver("YesButton",false);
				MyButton.SetActiver("NoButton",false);
			

				//	上の方でやってしまっているので調整
				ShopStatic.longPushTab.SetActive(false);
			}


		}






		//木の日誌を非表示にし、元の選択画面に戻る
		if(ShopStatic.isTreeDiary){

			//長押し説明タブと木のスクロールを再び表示
			ShopStatic.longPushTab.SetActive(true);
			ShopSVController.SaleTreeSetActiver(true);

			//日誌背景を非表示
			ShopStatic.backImageDiary.SetActive(false);

			//現在の日誌を非表示
			ShopStatic.shopTreeExplainTab[ShopStatic.shopNowDiaryTreeNumber].SetActive(false);

			ShopStatic.isTreeDiary = false;

			//UIを表示
			ShopStatic.ShopCoinObject.SetActive(true);
			ShopStatic.ShopRainbowObject.SetActive(true);

			//タブ番号も正しいものに戻す
			ShopStatic.shopNowTabNumber = 1;
		}

		//ヒトの日誌を非表示にし、元の選択画面に戻る
		if(ShopStatic.isHumanDiary){

			//長押し説明タブと木のスクロールを再び表示
			ShopStatic.longPushTab.SetActive(true);
			ShopSVController.SaleHumanSetActiver(true);

			//日誌背景を非表示
			ShopStatic.backImageDiary.SetActive(false);

			//現在の日誌を非表示
			ShopStatic.shopHumanExplainTab[ShopStatic.shopNowDiaryHumanNumber].SetActive(false);

			ShopStatic.isHumanDiary = false;

			//UIを表示
			ShopStatic.ShopCoinObject.SetActive(true);
			ShopStatic.ShopRainbowObject.SetActive(true);

			//タブ番号も正しいものに戻す
			ShopStatic.shopNowTabNumber = 1;

			
		}


		//研究所の日誌（便宜）を非表示にし、元の選択画面に戻る
		if(ShopStatic.isLaboDiary){

			//長押し説明タブと研究所のスクロールを再び表示
			ShopStatic.longPushTab.SetActive(true);
			ShopSVController.SaleLaboSetActiver(true);

			//日誌背景を非表示
			ShopStatic.backImageDiary.SetActive(false);

			//現在の日誌を非表示
			ShopStatic.shopLaboExplainTab[ShopStatic.shopNowDiaryLaboNumber].SetActive(false);

			ShopStatic.isLaboDiary = false;

			//UIを表示
			ShopStatic.ShopCoinObject.SetActive(true);
			ShopStatic.ShopRainbowObject.SetActive(true);

			//タブ番号も正しいものに戻す
			ShopStatic.shopNowTabNumber = 1;

			
		}

	}
}
