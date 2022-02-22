using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopYesController : MonoBehaviour {

	public void OnClicked(){

		//木や人材の購入の確認画面での　はい
		if(ShopStatic.shopNowTabNumber == 2){
			//確認タブとYes,Noボタンを非表示にし、tab等の管理。
			ShopStatic.confirmTab.SetActive(false);
			MyButton.SetActiver("YesButton",false);
			MyButton.SetActiver("NoButton",false);


			
			//続けて購入がしやすいように一つ前のスクロールタブに戻る。
			ShopStatic.longPushTab.SetActive(true);
			//ここでNowTabNumber変えていいと思う。
			ShopStatic.shopNowTabNumber = 1;

			

			//コイン、虹の延べ棒の管理

			if(ShopStatic.shopTabNumber == 2){

				//人材バージョン
				if(ShopStatic.isCoin == true){

					//個々でお買い上げの音声も流す。

					StaticRocker.CoinHolder -= ShopStatic.nowHumanPriceCoin;
					ShopCoinRainbowUI.DisplayCoinUI();

					//購入したやつのスタックを１増やす
					for(int i = 1; i < 7; i++){
						if(ShopStatic.shopHumanPriceDictionary[i] == ShopStatic.nowHumanPriceCoin){
							StaticRocker.allHuman[i]++;
						}
					}

					//(購入で所持金が減ったあとでも購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
					ShopActiveDirector.ActiveHumanChecker();

					ShopStatic.isCoin = false;

				}

				if(ShopStatic.isRainbow == true){
					StaticRocker.RainbowHolder -= ShopStatic.nowHumanPriceRainbow;
					ShopCoinRainbowUI.DisplayRainbowUI();

					//購入したやつのスタックを１増やす
					for(int i = 7; i < 14; i++){
						if(ShopStatic.shopHumanPriceDictionaryRain[i] == ShopStatic.nowHumanPriceRainbow){
							StaticRocker.allHuman[i]++;
						}
					}

					//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
					ShopActiveDirector.ActiveHumanChecker();

					ShopStatic.isRainbow = false;
				}

				//確認画面での人材の画像を非表示にする。
				for(int i = 1; i < 14; i++){
					ShopStatic.shopHuman[i].SetActive(false);
				}

				//スクロールを再表示
				ShopSVController.SaleHumanSetActiver(true);


			}else if(ShopStatic.shopTabNumber == 3){

				//研究所バージョン
				

				if(ShopStatic.isRainbow == true){
					StaticRocker.RainbowHolder -= ShopStatic.nowLaboPriceRainbow;
					ShopCoinRainbowUI.DisplayRainbowUI();

					//購入した研究所のフラグを立てて再購入を不可能にする
					StaticRocker.isLaboBought[ShopStatic.shopSelectedLabo] = true;


					//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
					ShopActiveDirector.ActiveLaboChecker();

					ShopStatic.isRainbow = false;


				}

				
				//確認画面での研究所の画像を非表示にする。
				for(int i = 1; i < 6; i++){
					ShopStatic.shopLabo[i].SetActive(false);
				}

				//スクロールを再表示
				ShopSVController.SaleLaboSetActiver(true);

				//現在選択されている研究所の番号を０に戻す
				ShopStatic.shopSelectedLabo = 0;



			}else if(ShopStatic.shopTabNumber == 1){

				//木バージョン
				if(ShopStatic.isCoin == true){

					//個々でお買い上げの音声も流す。

					StaticRocker.CoinHolder -= ShopStatic.nowTreePrice;
					ShopCoinRainbowUI.DisplayCoinUI();

					//購入したやつのスタックを１増やす
					for(int i = 1; i < 8; i++){
						if(ShopStatic.shopTreePriceDictionary[i] == ShopStatic.nowTreePrice){
							StaticRocker.allTree[i]++;
						}
					}


					
					//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
					ShopActiveDirector.ActiveTreeChecker();


					ShopStatic.isCoin = false;

					

				}

				if(ShopStatic.isRainbow == true){
					StaticRocker.RainbowHolder -= ShopStatic.nowTreePriceRainbow;
					ShopCoinRainbowUI.DisplayRainbowUI();

					//購入したやつのスタックを１増やす
					for(int i = 8; i < 14; i++){
						if(ShopStatic.shopTreePriceDictionaryRain[i] == ShopStatic.nowTreePriceRainbow){
							StaticRocker.allTree[i]++;
						}
					}

					//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
					ShopActiveDirector.ActiveTreeChecker();


					ShopStatic.isRainbow = false;
				}

				//確認画面での木の画像を非表示にする。
				for(int i = 1; i < 14; i++){
					ShopStatic.shopTree[i].SetActive(false);
				}

				//スクロールを再表示
				ShopSVController.SaleTreeSetActiver(true);


			}else if(ShopStatic.shopTabNumber == 4){
				//トレードバージョン

				//コインと延べ棒を実際に変換
				StaticRocker.CoinHolder -= ShopStatic.willTradeRainbow * 10000000000;
				StaticRocker.RainbowHolder += ShopStatic.willTradeRainbow;

				//コインと延べ棒のUIを更新
				ShopCoinRainbowUI.DisplayCoinUI();
				ShopCoinRainbowUI.DisplayRainbowUI();

				//上の方で全体でやってしまっているのでここを調整
				ShopStatic.longPushTab.SetActive(false);
				

				//現在のタブを非表示、最初のボタン4つを表示して初期状態に戻る
				ShopStatic.tradeTab.SetActive(false);

				//最初に表示されている４つのボタンを 表示する
				MyButton.SetActiver("ShopTree",true);
				MyButton.SetActiver("ShopHuman",true);
				MyButton.SetActiver("ShopLabo",true);
				MyButton.SetActiver("ShopCoinToBar",true);

				ShopStatic.shopTabNumber = 0;
				ShopStatic.shopNowTabNumber = 0;
			}
			

			
			
			
			
		}
	}
}
