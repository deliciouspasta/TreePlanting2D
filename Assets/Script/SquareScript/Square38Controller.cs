using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square38Controller : MonoBehaviour {

	//このスクリプト唯一の固有値
	int n = 38;

	void Start(){
		this.gameObject.SetActive(false);
	}

	


	public void Clicked(){
		if(!StaticRocker.isSquareActive[n] &&StaticRocker.isZoomed&& !CameraController.isGoneTabFlag&&StaticRocker.isCanSquareClick){
			StaticRocker.isSquareBool[n] = true;

			//現在選択されているスクエアの番号
			StaticRocker.NowSquareNumber = n;

			StaticRocker.tab1.SetActive(true);
			StaticRocker.tabNumber = 1;
			CameraController.isGoneTabFlag = true;
			MyButton.SetActiver("TabButtonBack",true);
			MyButton.SetActiver("BackButton",false);
			MyButton.SetActiver("TitleButton",false);
			MyButton.SetActiver("YesButton",true);
			MyButton.SetActiver("NoButton",true);

			//ほかのスクエアをクリックできないようにする
			StaticRocker.isCanSquareClick = false;
			
		}else if(StaticRocker.isCanSquareClick){
			//ここでタブの表示も行なう
			StaticRocker.isSellSquare[n] = true;
			CameraController.isGoneTabFlag = true;
			StaticRocker.tabA1.SetActive(true);
			StaticRocker.tabANumber = 1;

			//木の本数のみVERのUIを表示
			StaticRocker.treeAmount.SetActive(true);

			MyButton.SetActiver("TabButtonBack",true);
			MyButton.SetActiver("BackButton",false);
			MyButton.SetActiver("TitleButton",false);

			//ほかのスクエアをクリックできないようにする
			StaticRocker.isCanSquareClick = false;
			
			//そのスクエアがクリックされたときに現在時刻を取得する
			TimeDirector.Checker1OKU();
			TimeDirector.CheckerPlanting();

			//※注意※ここでSquareUIのDisplayUIは呼び出さないTimeDirectorの方で呼び出す。

			
			
			


		}
		
	}

	
}
