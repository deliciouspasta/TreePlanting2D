using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopCoinRainbowUI : MonoBehaviour {

	public static void DisplayCoinUI(){
		Text coinAmountText = ShopStatic.ShopCoinObject.GetComponent<Text>();
		coinAmountText.text = "ツリーコイン残高：" + StaticRocker.CoinHolder.ToString("N0");
	}

	public static void DisplayRainbowUI(){
		Text rainbowText = ShopStatic.ShopRainbowObject.GetComponent<Text>();
		rainbowText.text = "虹の延べ棒：" + StaticRocker.RainbowHolder.ToString("N0");
	}

	//トレード時のUI（延べ棒）
	public static void DisplayTradeRainbowUI(){
		Text tradeRainbowAmountText = ShopStatic.TradeRainbowObject.GetComponent<Text>();
		tradeRainbowAmountText.text =  ShopStatic.willTradeRainbow.ToString();
	}

	//トレード後の仮想的コイン残高UI
	public static void DisplayTradeVirtualCoinUI(long virtualCoin){
		Text tradeVirtualCoinAmountText = ShopStatic.TradeVirtualCoinObject.GetComponent<Text>();
		tradeVirtualCoinAmountText.text = "交換後のコイン残高 " + virtualCoin.ToString("N0");
	}

}
