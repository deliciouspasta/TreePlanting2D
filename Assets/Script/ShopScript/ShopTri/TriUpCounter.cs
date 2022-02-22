using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriUpCounter : MonoBehaviour {

	
	public void TriUp1Clicked(){
		
		ShopStatic.willTradeRainbow += 100000;

		//もし延べ棒100万本をこえたら999,999にしておく
		if(ShopStatic.willTradeRainbow >= 1000000){
			ShopStatic.willTradeRainbow = 999999;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriUp2Clicked(){
		ShopStatic.willTradeRainbow += 10000;

		//もし延べ棒100万本をこえたら999,999にしておく
		if(ShopStatic.willTradeRainbow >= 1000000){
			ShopStatic.willTradeRainbow = 999999;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriUp3Clicked(){
		ShopStatic.willTradeRainbow += 1000;

		//もし延べ棒100万本をこえたら999,999にしておく
		if(ShopStatic.willTradeRainbow >= 1000000){
			ShopStatic.willTradeRainbow = 999999;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriUp4Clicked(){
		ShopStatic.willTradeRainbow += 100;

		//もし延べ棒100万本をこえたら999,999にしておく
		if(ShopStatic.willTradeRainbow >= 1000000){
			ShopStatic.willTradeRainbow = 999999;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriUp5Clicked(){
		ShopStatic.willTradeRainbow += 10;

		//もし延べ棒100万本をこえたら999,999にしておく
		if(ShopStatic.willTradeRainbow >= 1000000){
			ShopStatic.willTradeRainbow = 999999;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

	public void TriUp6Clicked(){
		ShopStatic.willTradeRainbow += 1;

		//もし延べ棒100万本をこえたら999,999にしておく
		if(ShopStatic.willTradeRainbow >= 1000000){
			ShopStatic.willTradeRainbow = 999999;
		}

		//仮想コインUI表示
		VirtualCoinTrade.VirtualCoinCalc();

		//トレード延べ棒UI表示
		ShopCoinRainbowUI.DisplayTradeRainbowUI();
	}

}
