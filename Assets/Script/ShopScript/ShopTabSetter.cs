using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTabSetter : MonoBehaviour {

	//ここでタブの位置調整と非表示を行なう
	void Start () {

		ShopStatic.tradeExplainTab.transform.position = ShopStatic._camera.transform.position;
		ShopStatic.tradeTab.transform.position = ShopStatic._camera.transform.position;
		ShopStatic.longPushTab.transform.position = ShopStatic._camera.transform.position;
		ShopStatic.confirmTab.transform.position = ShopStatic._camera.transform.position;


		//ここでタブの位置調整
		ShopStatic.tradeExplainTab.transform.Translate(2,0,13);
		ShopStatic.tradeTab.transform.Translate(2,0,13);
		ShopStatic.longPushTab.transform.Translate(2,0,13);
		ShopStatic.confirmTab.transform.Translate(2,0,13);


		//タブの位置調整をしておかないといけない関係で、ここでタブの非表示を行なう
		ShopStatic.tradeExplainTab.SetActive(false);
		ShopStatic.tradeTab.SetActive(false);
		ShopStatic.longPushTab.SetActive(false);
		ShopStatic.confirmTab.SetActive(false);


		Debug.Log("kokokodadadayooooooooooooo");
	}
	
	
}
