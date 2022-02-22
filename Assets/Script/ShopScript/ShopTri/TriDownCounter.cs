using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriDownCounter : MonoBehaviour {

	
	public void TriDown1Clicked(){
		ShopStatic.willTradeRainbow -= 100000;

		//もし延べ棒0本を下回ったら0にしておく
		if(ShopStatic.willTradeRainbow  <= 0){
			ShopStatic.willTradeRainbow = 0;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriDown2Clicked(){
		ShopStatic.willTradeRainbow -= 10000;

		//もし延べ棒0本を下回ったら0にしておく
		if(ShopStatic.willTradeRainbow  <= 0){
			ShopStatic.willTradeRainbow = 0;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriDown3Clicked(){
		ShopStatic.willTradeRainbow -= 1000;

		//もし延べ棒0本を下回ったら0にしておく
		if(ShopStatic.willTradeRainbow  <= 0){
			ShopStatic.willTradeRainbow = 0;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriDown4Clicked(){
		ShopStatic.willTradeRainbow -= 100;

		//もし延べ棒0本を下回ったら0にしておく
		if(ShopStatic.willTradeRainbow  <= 0){
			ShopStatic.willTradeRainbow = 0;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriDown5Clicked(){
		ShopStatic.willTradeRainbow -= 10;

		//もし延べ棒0本を下回ったら0にしておく
		if(ShopStatic.willTradeRainbow  <= 0){
			ShopStatic.willTradeRainbow = 0;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriDown6Clicked(){
		ShopStatic.willTradeRainbow -= 1;

		//もし延べ棒0本を下回ったら0にしておく
		if(ShopStatic.willTradeRainbow  <= 0){
			ShopStatic.willTradeRainbow = 0;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

}
