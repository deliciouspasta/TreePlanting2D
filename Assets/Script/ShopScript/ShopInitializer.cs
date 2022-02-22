using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInitializer : MonoBehaviour {

	// Use this for initialization
	void Start () {

		ShopStatic._camera = GameObject.Find("Main Camera");

		ShopStatic.tradeExplainTab = GameObject.Find("TradeExplainTab");
		ShopStatic.tradeTab = GameObject.Find("TradeTab");
		ShopStatic.longPushTab = GameObject.Find("LongPushTab");
		ShopStatic.confirmTab = GameObject.Find("ConfirmTab");

		

		ShopStatic.tradeImage = GameObject.Find("TradeImage");
		ShopStatic.ShopCoinObject = GameObject.Find("CoinUI");
		ShopStatic.ShopRainbowObject = GameObject.Find("RainbowUI");

		ShopStatic.TradeRainbowObject = GameObject.Find("TradeRainbowUI");
		ShopStatic.TradeVirtualCoinObject = GameObject.Find("TradeVirtualCoinUI");

		
		


		//日誌タブの背景
		ShopStatic.backImageDiary = GameObject.Find("BackImageDiary");
		ShopStatic.backImageDiary.SetActive(false);


		//ShopSceneのボタンの非表示
		MyButton.SetActiver("YesButton",false);
		MyButton.SetActiver("NoButton",false);
		MyButton.SetActiver("TradeButton",false);
		MyButton.SetActiver("TriUpButtonDirector",false);
		MyButton.SetActiver("TriDownButtonDirector",false);

		//トレードのUIてきな画像の非表示
		ShopStatic.tradeImage.SetActive(false);

		//トレードのUIを非表示
		ShopStatic.TradeRainbowObject.SetActive(false);
		ShopStatic.TradeVirtualCoinObject.SetActive(false);

		//価格表に価格代入
		ShopPriceTable.PriceTableIni();

		


		////購入前の確認画面で表示するための木と人間と研究所
		for(int i = 1; i < 14; i++){
			ShopStatic.shopTree[i] = GameObject.Find("tree" + i.ToString());
			ShopStatic.shopTree[i].SetActive(false);
		}

		for(int i = 1; i < 14; i++){
			ShopStatic.shopHuman[i] = GameObject.Find("human" + i.ToString());
			ShopStatic.shopHuman[i].SetActive(false);
		}

		for(int i = 1; i < 6; i++){
			ShopStatic.shopLabo[i] = GameObject.Find("labo" + i.ToString());
			ShopStatic.shopLabo[i].SetActive(false);
		}

		//植林日誌タブの画像
		for(int i = 1; i < 14; i++){
			ShopStatic.shopTreeExplainTab[i] = GameObject.Find("tree" + i.ToString() + "Tab");
			ShopStatic.shopTreeExplainTab[i].SetActive(false);
		}

		//植林日誌タブの画像（ヒト）
		for(int i = 1; i < 14; i++){
			ShopStatic.shopHumanExplainTab[i] = GameObject.Find("human" + i.ToString() + "Tab");
			ShopStatic.shopHumanExplainTab[i].SetActive(false);
		}

		//日誌（便宜）タブの画像（研究所）
		for(int i = 1; i < 6; i++){
			ShopStatic.shopLaboExplainTab[i] = GameObject.Find("labo" + i.ToString() + "Tab");
			ShopStatic.shopLaboExplainTab[i].SetActive(false);
		}

		

		//ツリーコインと延べ棒の数を引き継ぎ
		ShopCoinRainbowUI.DisplayCoinUI();
		ShopCoinRainbowUI.DisplayRainbowUI();
	}
	
	
}
