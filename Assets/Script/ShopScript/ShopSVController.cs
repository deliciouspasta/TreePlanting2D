using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSVController : MonoBehaviour {


	static GameObject saletree;
	static GameObject salehuman;
	static GameObject saleLabo;


	//スクロールを非表示にしておく
	void Start () {
		saletree = GameObject.Find("SaleTreeScroll");
		saletree.SetActive(false);

		salehuman = GameObject.Find("SaleHumanScroll");
		salehuman.SetActive(false);

		saleLabo = GameObject.Find("SaleLaboScroll");
		saleLabo.SetActive(false);
	}
	

	//StaticRockerに入れずにtrue,falseの切り替えを行なう。
	public static void SaleTreeSetActiver(bool b){
		saletree.SetActive(b);
	}
	
	public static void SaleHumanSetActiver(bool b){
		salehuman.SetActive(b);
	}

	public static void SaleLaboSetActiver(bool b){
		saleLabo.SetActive(b);
	}
}
