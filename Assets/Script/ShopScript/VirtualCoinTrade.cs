using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class VirtualCoinTrade : MonoBehaviour {

	public static void VirtualCoinCalc(){

		//現在のコインの数で交換できる最大の延べ棒の本数
		long nowMaxRainbow;

		//現在のコインの残高を仮想的に表示するための変数
		long virtualCoin;
		//現在のコインの残高の実際の値
		long virtualCoinFirst;

		virtualCoin = StaticRocker.CoinHolder;
		virtualCoinFirst = StaticRocker.CoinHolder;

		//	現在のコインの数で交換できる最大の延べ棒の本数を算出
		nowMaxRainbow = virtualCoinFirst / 10000000000;

		//延べ棒の本数を整数にするために小数点以下を切り捨てる
		//Mathf.Floor(nowMaxRainbow);
		

		//交換しようとしている延べ棒の数が最大の延べ棒の数を上回ったら、、
		if(ShopStatic.willTradeRainbow > nowMaxRainbow){

			//無理矢理最大の延べ棒の数にする
			ShopStatic.willTradeRainbow = nowMaxRainbow;

			
		}

		/* float fLOgjo = 1000000030000;
		long LOngrie = 1000000030000;
		Debug.Log(fLOgjo-5+"kore");
		Debug.Log(LOngrie-5);*/


		//もし交換した場合のコイン残高
		virtualCoin = virtualCoinFirst - ShopStatic.willTradeRainbow * 10000000000;

		/* Debug.Log((long)virtualCoinFirst+"aaa");
		Debug.Log((double)virtualCoin+"bbb");
		Debug.Log(ShopStatic.willTradeRainbow);
		Debug.Log(ShopStatic.willTradeRainbow * 10000000000.0f);
		Debug.Log(virtualCoinFirst - ShopStatic.willTradeRainbow * 10000000000.0f);
		Debug.Log(10000000000.0f-10000000000.0f);*/

		//UIで仮想的コイン残高を表示
		ShopCoinRainbowUI.DisplayTradeVirtualCoinUI(virtualCoin);


	}
	
	
}
