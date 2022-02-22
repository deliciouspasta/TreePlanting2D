using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeButtonController : MonoBehaviour {

	public void OnClicked(){
		if(ShopStatic.shopNowTabNumber == 1){

			//トレードしてよろしいですかタブを開く
			ShopStatic.tradeTab.SetActive(true);

			//前のタブやUIなど不必要なものを非表示
			ShopStatic.tradeExplainTab.SetActive(false);
			ShopStatic.TradeRainbowObject.SetActive(false);
			ShopStatic.TradeVirtualCoinObject.SetActive(false);
			ShopStatic.tradeImage.SetActive(false);
			MyButton.SetActiver("TradeButton",false);
			MyButton.SetActiver("TriUpButtonDirector",false);
			MyButton.SetActiver("TriDownButtonDirector",false);


			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);
			

			ShopStatic.shopNowTabNumber = 2;
		}
	}
}
