using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUIController : MonoBehaviour {


	///StaticRockerがさらにわかりづらくなるので特別にここに置いておく
	//public static Text coinAmountText;


	/* void Start(){
		
		
		//CoinUIController.DisplayCoinUI();
		//DontDestroyOnLoad(CoinUIController.coinAmountText);
		
	}*/

	public static void DisplayCoinUI(){
		Text coinAmountText = StaticRocker.coinAmount.GetComponent<Text>();
		coinAmountText.text = "ツリーコイン残高：" + StaticRocker.CoinHolder.ToString("N0");
	}
}
