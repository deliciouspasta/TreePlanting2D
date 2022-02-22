using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeDirector : MonoBehaviour {

	
	public static void NowStartTimeGeter(){
		for(int i = 0; i < 200; i++){
			if(StaticRocker.isSquareActive[i] == true){
				StaticRocker.startTime[i] = DateTime.Now.Ticks;
			}
		}
	}

	public static void EndTimeGeter(){
		for(int i = 0; i < 200; i++){
			if(StaticRocker.isSquareActive[i] == true){
				StaticRocker.endTime[i] = DateTime.Now.Ticks;
			}
		}
	}


	//	植林中or植林完了
	public static void CheckerPlanting(){
		int i;
		long temp;

		Debug.Log("CheckerPlantingそのもの");

		//現在時刻の更新
		EndTimeGeter();

		for(i = 0; i < 200; i++){
			if(StaticRocker.isSquareActive[i] == true && StaticRocker.isPlanting[i] == true){

				

				//下の壱行で時刻差を求めて秒数に変換している
				StaticRocker.diffTime[i] = (StaticRocker.endTime[i] - StaticRocker.startTime[i]) / (1000*1000*10);

				Debug.Log(StaticRocker.diffTime[i]+"difftime");

				//現在の植林本数(１３なら末尾が１００万)
				temp = (StaticRocker.diffTime[i]  / StaticRocker.ONEHOUR * StaticRocker.humanInfo[i].plantSpeed)  +  StaticRocker.momentHuman13[i];

				Debug.Log(temp);
				


				if(temp >= 1000000){

					StaticRocker.isPlanting[i] = false;
					StaticRocker.treeInfo[i].treeHonsuu = 1000000;

					//クリックして選択されたスクエアの情報だけUIとして表示する。あと木の画像も。
					if(StaticRocker.isSellSquare[i] == true){
						SquareUIDirector.DisplayUI(StaticRocker.treeInfo[i].treeHonsuu);

						//何の木を選択したかの画像を表示する
						StaticRocker.treeItem[StaticRocker.selectedTreeS[i]].SetActive(true);
					}
					
					
				}else{
					StaticRocker.treeInfo[i].treeHonsuu = temp;
					

					Debug.Log(StaticRocker.treeInfo[i].treeHonsuu+"treeInfo[i].treeHonsuu");

					//クリックして選択されたスクエアの情報だけUIとして表示する。あと木の画像も。
					if(StaticRocker.isSellSquare[i] == true){
						SquareUIDirector.DisplayUI(StaticRocker.treeInfo[i].treeHonsuu);

						//何の木を選択したかの画像を表示する
						StaticRocker.treeItem[StaticRocker.selectedTreeS[i]].SetActive(true);
					}

					Debug.Log("CheckerPlanting 100万以下");
				}
			}
		}
	}


	
	//植林開始時と現在時刻の差分を計算して秒数の差分を配列に格納、そして木の本数が1億を超えているかを判定
	public static void Checker1OKU(){
		int i;
		double temp = 0;
		long sellingPricetemp = 0;
		//現在時刻の更新
		EndTimeGeter();

		for(i = 0; i < 200; i++){
			if(StaticRocker.isSquareActive[i] == true && StaticRocker.isPlanting[i] == false ){

				//下の一行で時刻差を求め、それを秒数変換している。
				StaticRocker.diffTime[i] = (StaticRocker.endTime[i] - StaticRocker.startTime[i]) / (1000*1000*10);


				//	ここの　1　はさいしょの100万本の　1
				temp = ( 1 +  StaticRocker.diffTime[i] / StaticRocker.ONEHOUR * StaticRocker.treeInfo[i].breed ) + StaticRocker.momentTree13[i];

				//
				Debug.Log("endtime "+ StaticRocker.endTime[i]);
				Debug.Log("starttime"+ StaticRocker.startTime[i]);
				Debug.Log("diffTime "+ StaticRocker.diffTime[i]);
				Debug.Log("isSellSquare "+StaticRocker.isSellSquare[i]);
				Debug.Log("temp "+ temp);
				Debug.Log("OneHour "+StaticRocker.ONEHOUR);
				Debug.Log("treeInfobreed "+StaticRocker.treeInfo[i].breed);


				//1億本を超えたかのチェック
				if( temp >= 100.0 ){
					StaticRocker.isBreedFinish[i] = true;
					StaticRocker.treeInfo[i].treeHonsuu = 100000000;

					//一億本を超えたスクエアの緑の画像を見つけ出し、表示する。
					MidoriController.MidoriAppear(i, true);

					
					//三日ぐらいで最大にしとかないとイケない
					sellingPricetemp = StaticRocker.treeInfo[i].sellingPrice*(   1 + StaticRocker.diffTime[i] / StaticRocker.ONEDAY   );

				//	配列にコインの実際の売却値を格納
                    StaticRocker.realSellingPrice[i] = sellingPricetemp;

					//クリックして選択されたスクエアの情報だけUIとして表示する。あと木の画像も。
					if(StaticRocker.isSellSquare[i] == true){


						//木の本数と売却値のUIをまず表示させ、もとの、木の本数だけ表示するUIは非表示にする。
						StaticRocker.nowcointreeUI.SetActive(true);
						StaticRocker.treeAmount.SetActive(false);
						
						//1億本と売価を表示
						SquareUIDirector.DisplayUI(StaticRocker.treeInfo[i].treeHonsuu , sellingPricetemp);


						//何の木を選択したかの画像を表示する
						StaticRocker.treeItem[StaticRocker.selectedTreeS[i]].SetActive(true);


						//売却ボタンを表示
						MyButton.SetActiver("UruButton", true);
					}

					

					

				//超えてなかったら現在の本数を配列に格納、UIで現在の本数を表示
				}else{
					StaticRocker.treeInfo[i].treeHonsuu = (long) (temp * 1000000);


					//クリックして選択されたスクエアの情報だけUIとして表示する。あと木の画像も。
					if(StaticRocker.isSellSquare[i] == true){
						SquareUIDirector.DisplayUI(StaticRocker.treeInfo[i].treeHonsuu);

						//何の木を選択したかの画像を表示する
						StaticRocker.treeItem[StaticRocker.selectedTreeS[i]].SetActive(true);
					}
					
				}
			}
		}

		
		
		
	}

	

	
}
