using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree5Controller : MonoBehaviour {

	//この木の番号
	private int n = 5;

	//残りのアイテムの数をひょうじするためのUI 
	void Start(){
		StaticRocker.allTreeNumberUI[n] = transform.GetChild(0).gameObject;
	}
	
	public void OnClicking(){

		

		// tree系統のアイテムはこれを使わせる
		ScrollViewButtonController.ItemTab2to3();
		
		ScrollViewController.SVHSetActiver(true);

		//選択した木を確認画面で表示
		StaticRocker.treeItem[n].SetActive(true);

		//現在の番号をこの木の番号にする
		StaticRocker.selectedTree = n;
		

		StaticRocker.TreeInfo　thistreeInfo = new StaticRocker.TreeInfo();

		
		thistreeInfo.breed = 16.7;
		thistreeInfo.sellingPrice = 10000000000;

		//treeの情報をクリックされたスクエアのツリー箱に格納する
		for(int i = 0; i < 200; i++){
			if(StaticRocker.isSquareBool[i] == true){
				StaticRocker.treeInfo[i] = thistreeInfo;

				//売却時に確認できるようにこの配列にも木の番号を入れておく
				StaticRocker.selectedTreeS[i] = n;
			}
		}

		//スクロールのボタン要素を一つずつチェックして表示(するためにスタックの確認)
		ItemChecker.ItemHumanFlager();


		//木のスクロールを閉じる
		ScrollViewController.SVSetActiver(false);




	}

	
}
