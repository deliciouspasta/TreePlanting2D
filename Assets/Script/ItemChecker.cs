using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChecker : MonoBehaviour {

	
	//	木を植えるときにどの木を表示してよいかを調べる
	public static void ItemDisplay(){
		ScrollViewButtonController.SetScrollActiver("NodeButton (1)",StaticRocker.isTree[1]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (2)",StaticRocker.isTree[2]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (3)",StaticRocker.isTree[3]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (4)",StaticRocker.isTree[4]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (5)",StaticRocker.isTree[5]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (6)",StaticRocker.isTree[6]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (7)",StaticRocker.isTree[7]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (8)",StaticRocker.isTree[8]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (9)",StaticRocker.isTree[9]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (10)",StaticRocker.isTree[10]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (11)",StaticRocker.isTree[11]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (12)",StaticRocker.isTree[12]);
		ScrollViewButtonController.SetScrollActiver("NodeButton (13)",StaticRocker.isTree[13]);
		
	}

	//　アイテムのスタックの数が０ならFalse,１以上ならTrueにする
	public static void ItemTreeFlager(){

		//購入を促す画像を表示する
		StaticRocker.pleaseBuyImage.SetActive(true);

		for(int i = 1; i < 14; i++){
			if(StaticRocker.allTree[i] == 0){
				StaticRocker.isTree[i] = false;
			}else{
				StaticRocker.isTree[i] = true;

				//購入を促す画像は非表示にする
				StaticRocker.pleaseBuyImage.SetActive(false);

			}
		}

		//　ItemDisplayを呼び出してスクロールのボタンを正しく表示する
		ItemChecker.ItemDisplay();

		//スタックの数を表示
		AllNumberUIController.AllNumberTreeDisplayUI();
	}


	//	人材選択の時にどの人材を表示してよいかを調べる
	public static void ItemDisplayHuman(){
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (1)",StaticRocker.isHuman[1]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (2)",StaticRocker.isHuman[2]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (3)",StaticRocker.isHuman[3]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (4)",StaticRocker.isHuman[4]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (5)",StaticRocker.isHuman[5]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (6)",StaticRocker.isHuman[6]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (7)",StaticRocker.isHuman[7]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (8)",StaticRocker.isHuman[8]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (9)",StaticRocker.isHuman[9]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (10)",StaticRocker.isHuman[10]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (11)",StaticRocker.isHuman[11]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (12)",StaticRocker.isHuman[12]);
		ScrollViewHumanButtonController.SetScrollActiver("NodeButtonHuman (13)",StaticRocker.isHuman[13]);


		
	}

	//　アイテムのスタックの数が０ならFalse,１以上ならTrueにする
	public static void ItemHumanFlager(){
		//購入を促す画像を表示する
		StaticRocker.pleaseBuyImage.SetActive(true);
		for(int i = 1; i < 14; i++){
			if(StaticRocker.allHuman[i] == 0){
				StaticRocker.isHuman[i] = false;
			}else{
				StaticRocker.isHuman[i] = true;
				//購入を促す画像は非表示にする
				StaticRocker.pleaseBuyImage.SetActive(false);
			}
		}

		//　ItemDisplayHumanを呼び出してスクロールのボタンを正しく表示する
		ItemChecker.ItemDisplayHuman();

		//スタックの数を表示
		AllNumberUIController.AllNumberHumanDisplayUI();
	}
}
