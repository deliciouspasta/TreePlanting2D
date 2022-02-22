using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopActiveDirector : MonoBehaviour {

	public static void ActiveTreeChecker(){

		//開発番号とショップやマップシーンでのアイテムの開発番号を揃える
		bool[] thisIsTreeDeved = new bool[14];
		thisIsTreeDeved[8] = StaticRocker.isDeved[1];
		thisIsTreeDeved[9] = StaticRocker.isDeved[5];
		thisIsTreeDeved[10] = StaticRocker.isDeved[8];
		thisIsTreeDeved[11] = StaticRocker.isDeved[9];
		thisIsTreeDeved[12] = StaticRocker.isDeved[11];
		thisIsTreeDeved[13] = StaticRocker.isDeved[12];


	
		// 木(購入金額を所持金がちゃんと上回っている、かつ開発済み（後半）ならボタンを反応可能にする)
		for(int i = 1; i < 8; i++){

			if(StaticRocker.CoinHolder >= ShopStatic.shopTreePriceDictionary[i]  ){
				ShopMyTreeButton.InteractablerTree("SaleTreeButton" + " (" + i.ToString() + ")", true);
				Debug.Log(StaticRocker.CoinHolder);
			}else{
				ShopMyTreeButton.InteractablerTree("SaleTreeButton" + " (" + i.ToString() + ")", false);
			}
		}

		for(int i = 8; i < 14; i++){

			if( StaticRocker.CoinHolder >= ShopStatic.shopTreePriceDictionary[i] && StaticRocker.RainbowHolder >= ShopStatic.shopTreePriceDictionaryRain[i]&&thisIsTreeDeved[i]){
				ShopMyTreeButton.InteractablerTree("SaleTreeButton" + " (" + i.ToString() + ")", true);
			}else{
				ShopMyTreeButton.InteractablerTree("SaleTreeButton" + " (" + i.ToString() + ")", false);
			}
		}

	}

	public static void ActiveHumanChecker(){

		//開発番号とショップやマップシーンでのアイテムの開発番号を揃える
		bool[] thisIsHumanDeved = new bool[14];
		thisIsHumanDeved[7] = StaticRocker.isDeved[1];
		thisIsHumanDeved[8] = StaticRocker.isDeved[3];
		thisIsHumanDeved[9] = StaticRocker.isDeved[4];
		thisIsHumanDeved[10] = StaticRocker.isDeved[6];
		thisIsHumanDeved[11] = StaticRocker.isDeved[7];
		thisIsHumanDeved[12] = StaticRocker.isDeved[10];
		thisIsHumanDeved[13] = StaticRocker.isDeved[13];


		//人材(購入金額を所持金がちゃんと上回っている、かつ開発済み（後半）ならボタンを反応可能にする)
		for(int i = 1; i < 7; i++){

			if(StaticRocker.CoinHolder >= ShopStatic.shopHumanPriceDictionary[i] ){
				ShopMyHumanButton.Interactabler("SaleHumanButton" + " (" + i.ToString() + ")", true);
			}else{
				ShopMyHumanButton.Interactabler("SaleHumanButton" + " (" + i.ToString() + ")", false);
			}
		}
		for(int i = 7; i < 14; i++){

			if(StaticRocker.RainbowHolder >= ShopStatic.shopHumanPriceDictionaryRain[i]&&thisIsHumanDeved[i]){
				ShopMyHumanButton.Interactabler("SaleHumanButton" + " (" + i.ToString() + ")", true);
			}else{
				ShopMyHumanButton.Interactabler("SaleHumanButton" + " (" + i.ToString() + ")", false);
			}
		}
	}
		
		
	public static void ActiveLaboChecker(){
		//研究所（購入金額を所持金がちゃんと上回っていたらボタンを反応可能にする）
		for(int i = 1; i < 6; i++){
			if(StaticRocker.RainbowHolder >= ShopStatic.shopLaboPriceDictionaryRain[i] && !StaticRocker.isLaboBought[i]){
				ShopMyLaboButton.InteractablerLabo("SaleLaboButton" + " (" + i.ToString() + ")", true);
			}else{
				ShopMyLaboButton.InteractablerLabo("SaleLaboButton" + " (" + i.ToString() + ")", false);
			}
		}
	}
		
	
}
