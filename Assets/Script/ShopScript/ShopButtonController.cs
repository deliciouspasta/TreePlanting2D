using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonController : MonoBehaviour {

	
	void Start () {
		
	}
	

	//ShopSceneの最初のボタンがクリックされたときに呼び出される関数
	public void ShopTreeClicked(){
		ShopStatic.longPushTab.SetActive(true);
		ShopSVController.SaleTreeSetActiver(true);

		//最初に表示されている４つのボタンを非表示にする
		MyButton.SetActiver("ShopTree",false);
		MyButton.SetActiver("ShopHuman",false);
		MyButton.SetActiver("ShopLabo",false);
		MyButton.SetActiver("ShopCoinToBar",false);

		//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
		ShopActiveDirector.ActiveTreeChecker();

		//タブの種類
		ShopStatic.shopTabNumber = 1;

		//何層目のタブか。
		ShopStatic.shopNowTabNumber = 1;
	}

	public void ShopHumanClicked(){
		ShopStatic.longPushTab.SetActive(true);
		ShopSVController.SaleHumanSetActiver(true);

		//最初に表示されている４つのボタンを非表示にする
		MyButton.SetActiver("ShopTree",false);
		MyButton.SetActiver("ShopHuman",false);
		MyButton.SetActiver("ShopLabo",false);
		MyButton.SetActiver("ShopCoinToBar",false);

		//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
		ShopActiveDirector.ActiveHumanChecker();

		//タブの種類
		ShopStatic.shopTabNumber = 2;
		//何層目のタブか。
		ShopStatic.shopNowTabNumber = 1;
	}

	public void ShopLaboClicked(){
		ShopStatic.longPushTab.SetActive(true);
		ShopSVController.SaleLaboSetActiver(true);

		//最初に表示されている４つのボタンを非表示にする
		MyButton.SetActiver("ShopTree",false);
		MyButton.SetActiver("ShopHuman",false);
		MyButton.SetActiver("ShopLabo",false);
		MyButton.SetActiver("ShopCoinToBar",false);

		//(購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする)
		ShopActiveDirector.ActiveLaboChecker();

		ShopStatic.shopTabNumber = 3;
		ShopStatic.shopNowTabNumber = 1;
	}

	public void ShopCoinToBarClicked(){
		ShopStatic.tradeExplainTab.SetActive(true);
		ShopStatic.tradeImage.SetActive(true);

		//交換する　ボタンの表示
		MyButton.SetActiver("TradeButton",true);

		//三角ボタンの表示
		MyButton.SetActiver("TriUpButtonDirector",true);
		MyButton.SetActiver("TriDownButtonDirector",true);

		//最初に表示されている４つのボタンを非表示にする
		MyButton.SetActiver("ShopTree",false);
		MyButton.SetActiver("ShopHuman",false);
		MyButton.SetActiver("ShopLabo",false);
		MyButton.SetActiver("ShopCoinToBar",false);

		//仮想UIを表示する
		ShopStatic.TradeRainbowObject.SetActive(true);
		ShopStatic.TradeVirtualCoinObject.SetActive(true);

		//初期状態（延べ棒0本選択）を表示させる
		VirtualCoinTrade.VirtualCoinCalc();
		ShopCoinRainbowUI.DisplayTradeRainbowUI();

		ShopStatic.shopTabNumber = 4;
		ShopStatic.shopNowTabNumber = 1;
	}
}
