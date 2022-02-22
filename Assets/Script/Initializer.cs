using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour {

	
	

	// ここでさまざまなStaticへんすう、オブジェクトを初期化する。
	void Start () {
		
		Debug.Log("Initializer");

		StaticRocker._camera = GameObject.Find("Main Camera");
		
		StaticRocker.MidoriHolding = GameObject.Find("MidoriHolding");


		
		
		

		StaticRocker.tab1 = GameObject.Find("BackImageItem1");
		StaticRocker.tab2 = GameObject.Find("BackImageItem2");
		StaticRocker.tab3 = GameObject.Find("BackImageItem3");
		StaticRocker.tab4 = GameObject.Find("BackImageItem4");

		StaticRocker.tabA1 = GameObject.Find("BackImageItemA1");
		StaticRocker.tabA2 = GameObject.Find("BackImageItemA2");

		

		StaticRocker.tabbuttonback = GameObject.Find("Canvas.TabButtonBack");
		StaticRocker.treeAmount = GameObject.Find("SquareUI");
		StaticRocker.coinAmount = GameObject.Find("Coin");
		StaticRocker.nowcointreeUI = GameObject.Find("NowCoinTreeUI");

		StaticRocker.treeHolding = GameObject.Find("TreeHolding");
		StaticRocker.humanHolding = GameObject.Find("HumanHolding");

		StaticRocker.pleaseBuyImage = GameObject.Find("PleaseBuyImage");
		StaticRocker.pleaseBuyImage.SetActive(false);

		

		StaticRocker.treeItem[1] = GameObject.Find("tree1");
		StaticRocker.treeItem[2] = GameObject.Find("tree2");
		StaticRocker.treeItem[3] = GameObject.Find("tree3");
		StaticRocker.treeItem[4] = GameObject.Find("tree4");
		StaticRocker.treeItem[5] = GameObject.Find("tree5");
		StaticRocker.treeItem[6] = GameObject.Find("tree6");
		StaticRocker.treeItem[7] = GameObject.Find("tree7");
		StaticRocker.treeItem[8] = GameObject.Find("tree8");
		StaticRocker.treeItem[9] = GameObject.Find("tree9");
		StaticRocker.treeItem[10] = GameObject.Find("tree10");
		StaticRocker.treeItem[11] = GameObject.Find("tree11");
		StaticRocker.treeItem[12] = GameObject.Find("tree12");
		StaticRocker.treeItem[13] = GameObject.Find("tree13");

		StaticRocker.treeItem[1].SetActive(false);
		StaticRocker.treeItem[2].SetActive(false);
		StaticRocker.treeItem[3].SetActive(false);
		StaticRocker.treeItem[4].SetActive(false);
		StaticRocker.treeItem[5].SetActive(false);
		StaticRocker.treeItem[6].SetActive(false);
		StaticRocker.treeItem[7].SetActive(false);
		StaticRocker.treeItem[8].SetActive(false);
		StaticRocker.treeItem[9].SetActive(false);
		StaticRocker.treeItem[10].SetActive(false);
		StaticRocker.treeItem[11].SetActive(false);
		StaticRocker.treeItem[12].SetActive(false);
		StaticRocker.treeItem[13].SetActive(false);


		StaticRocker.humanItem[1] = GameObject.Find("human1");
		StaticRocker.humanItem[2] = GameObject.Find("human2");
		StaticRocker.humanItem[3] = GameObject.Find("human3");
		StaticRocker.humanItem[4] = GameObject.Find("human4");
		StaticRocker.humanItem[5] = GameObject.Find("human5");
		StaticRocker.humanItem[6] = GameObject.Find("human6");
		StaticRocker.humanItem[7] = GameObject.Find("human7");
		StaticRocker.humanItem[8] = GameObject.Find("human8");
		StaticRocker.humanItem[9] = GameObject.Find("human9");
		StaticRocker.humanItem[10] = GameObject.Find("human10");
		StaticRocker.humanItem[11] = GameObject.Find("human11");
		StaticRocker.humanItem[12] = GameObject.Find("human12");
		StaticRocker.humanItem[13] = GameObject.Find("human13");

		StaticRocker.humanItem[1].SetActive(false);
		StaticRocker.humanItem[2].SetActive(false);
		StaticRocker.humanItem[3].SetActive(false);
		StaticRocker.humanItem[4].SetActive(false);
		StaticRocker.humanItem[5].SetActive(false);
		StaticRocker.humanItem[6].SetActive(false);
		StaticRocker.humanItem[7].SetActive(false);
		StaticRocker.humanItem[8].SetActive(false);
		StaticRocker.humanItem[9].SetActive(false);
		StaticRocker.humanItem[10].SetActive(false);
		StaticRocker.humanItem[11].SetActive(false);
		StaticRocker.humanItem[12].SetActive(false);
		StaticRocker.humanItem[13].SetActive(false);

		
		StaticRocker.treeAmount.SetActive(false);
		StaticRocker.nowcointreeUI.SetActive(false);

		

		//緑の画像を全て非表示
		foreach(Transform midoriChild in StaticRocker.MidoriHolding.transform){
			midoriChild.gameObject.SetActive(false);
		}

		/* for(int i = 0; i < 20; i++){
			Debug.Log(SaveData.Instance.SampleArray[i] + i.ToString());
		} */


		//ここでチェックを入れる
		SaveData.Instance.GameFinSecondChecker();


		//
		Debug.Log("BeforeStaticRockerTreeBreed "+StaticRocker.treeInfo[11].breed);
		

		//一度ゲームが閉じている状態なら実行される
		if(StaticRocker.isGameFin){
			if(StaticRocker.isSecond){
			//保存しておいたデータを代入する
				
				SaveData.Instance.StartSubstitutioner();
				Debug.Log("Inisucceed "+ SaveData.Instance.isSquareActive[5]);
			}else{
				StaticRocker.isSecond = true;
			}
		}

		CoinUIController.DisplayCoinUI();

		
		Debug.Log("isGameFin   "+ StaticRocker.isGameFin);
		Debug.Log("isSecond " + StaticRocker.isSecond);
		Debug.Log("isSquareActive5" + SaveData.Instance.isSquareActive[5]);
		Debug.Log("AfterStaticRockerTreeBreed "+StaticRocker.treeInfo[11].breed);
		

		
		

		
		

	}
	
	
}
