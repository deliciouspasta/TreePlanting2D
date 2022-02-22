using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopNoController : MonoBehaviour {

	
	public void OnClicked(){

		//木や人材の購入の確認画面での　いいえ
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
	}
	
}
