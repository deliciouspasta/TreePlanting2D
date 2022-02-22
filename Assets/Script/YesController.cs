using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesController : MonoBehaviour {

	
	public void YesClicked(){
		
		//この場所に木を植えますか？のタブ
		if(StaticRocker.tabNumber == 1){
			StaticRocker.tab1.SetActive(false);
			StaticRocker.tab2.SetActive(true);
			StaticRocker.tabNumber = 2;

			//スタックチェック
			ItemChecker.ItemTreeFlager();

			ScrollViewController.SVSetActiver(true);
			MyButton.SetActiver("YesButton",false);
			MyButton.SetActiver("NoButton",false);
			
		}

//最後の確認画面でのYES
		if(StaticRocker.tabNumber == 4){
			StaticRocker.tabNumber = 0;
			StaticRocker.tab4.SetActive(false);
			MyButton.SetActiver("YesButton",false);
			MyButton.SetActiver("NoButton",false);
			MyButton.SetActiver("BackButton",true);
			CameraController.isGoneTabFlag = false;

			//どのスクエアでもクリック可能にする
			StaticRocker.isCanSquareClick = true;

			for(int i = 0; i < 200; i++){
				if(StaticRocker.isSquareBool[i] == true){
					StaticRocker.isSquareBool[i] = false;
					StaticRocker.isPlanting[i] = true;
					StaticRocker.isSquareActive[i] = true;

					//もし１３番目だったら速攻で完了するので、、、
					if(StaticRocker.selectedTree == 13){
						StaticRocker.momentTree13[i] = 100;
					}
					if(StaticRocker.selectedHuman == 13){
						StaticRocker.momentHuman13[i] = 1000000;
					}
					
					TimeDirector.NowStartTimeGeter();

					Debug.Log(StaticRocker.startTime[i]+"YES");


					//　該当するallTreeとallHumanのスタックをそれぞれ１減らす
					StaticRocker.allTree[StaticRocker.selectedTree]--;
					StaticRocker.allHuman[StaticRocker.selectedHuman]--;

					//確認画面の画像を非表示にする
					StaticRocker.treeItem[StaticRocker.selectedTree].SetActive(false);
					StaticRocker.humanItem[StaticRocker.selectedHuman].SetActive(false);
					StaticRocker.selectedTree = 0;
					StaticRocker.selectedHuman = 0;

					//現在のスクエア番号の値を存在しない値にする
					StaticRocker.NowSquareNumber = 999;

					Debug.Log("選択された木の番号は"+ StaticRocker.selectedTree);

					return;
				}
			}

		}


	    //	売却しますか？→　はい
		if(StaticRocker.tabANumber == 2){

			Debug.Log("koinkoin");

			

			for(int i = 0; i < 200; i++){
				if(StaticRocker.isSellSquare[i] == true){

					//緑画像を非表示
					MidoriController.MidoriAppear(i, false);

					//そのスクエアが持つboolはこれですべてがfalseとなる
					StaticRocker.isSellSquare[i] = false;
					StaticRocker.isSquareActive[i] = false;
					StaticRocker.isBreedFinish[i] = false;

					CameraController.isGoneTabFlag = false;
					StaticRocker.tabA2.SetActive(false);
					StaticRocker.tabANumber = 0;

					//UIを非表示にする
					StaticRocker.nowcointreeUI.SetActive(false);

					//確認用の木の画像を非表示にする
					StaticRocker.treeItem[StaticRocker.selectedTreeS[i]].SetActive(false);

					MyButton.SetActiver("TabButtonBack",false);
					MyButton.SetActiver("BackButton",true);
					MyButton.SetActiver("UruButton", false);
					MyButton.SetActiver("YesButton",false);
					MyButton.SetActiver("NoButton",false);


					//所持コインが売却値のぶんだけ増加する
					StaticRocker.CoinHolder += StaticRocker.realSellingPrice[i];

					Debug.Log(StaticRocker.realSellingPrice[i]);

					CoinUIController.DisplayCoinUI();

					//どのスクエアでもクリック可能にする
					StaticRocker.isCanSquareClick = true;



					

					break;
				}
			}

			
		}
	}
}
