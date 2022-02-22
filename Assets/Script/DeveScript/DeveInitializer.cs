using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveInitializer : MonoBehaviour {

	
	void Start () {

		DeveStatic.deveComfirmTab = GameObject.Find("DeveComfirmTab");
		DeveStatic.deveFinTab = GameObject.Find("DeveFinTab");
		DeveStatic.DeveRainbowObject = GameObject.Find("DeveRainbowUI");

		DeveMyButton.DeveSetActiver("DeveYesButton",false);
		DeveMyButton.DeveSetActiver("DeveNoButton",false);
		DeveMyButton.DeveSetActiver("DeveOKButton",false);


		DeveStatic.deveComfirmTab.SetActive(false);
		DeveStatic.deveFinTab.SetActive(false);

		//アイテム群ホルダーを探索。注：非表示にはしなくても下でされているから大丈夫だと思う。
		for(int i = 1; i < 6; i++){
			DeveStatic.laboCanHolders[i] = GameObject.Find("Labo"+i.ToString()+"CanHolder");
		}

		//アイテム群ホルダーを非表示にする
		for(int i = 1; i < 6; i++){
			DeveMyButton.DeveSetActiver("Labo"+i.ToString()+"CanHolder",false);
		}

		for(int i = 1; i < 6; i++){
			DeveStatic.deveLabo[i] = GameObject.Find( "labo"+i.ToString() );
			DeveStatic.deveLabo[i].SetActive(false);
		}

		//確認画面で表示する開発アイテムの画像を非表示
		for(int i = 1; i < 14; i++){
			DeveStatic.deveItem[i] = GameObject.Find( "DeveItem"+i.ToString() );
			DeveStatic.deveItem[i].SetActive(false);
		}

		//研究所の説明タブを格納、非表示
		for(int i = 1; i < 6; i++){
			DeveStatic.deveLaboExplain[i] = GameObject.Find("labo" + i.ToString() + "Tab");
			DeveStatic.deveLaboExplain[i].SetActive(false);
		}

		//虹の延べ棒の本数を表示（引継ぎ）
		DeveUIController.DeveDisplayRainbowUI();

		//配列に開発費を代入する
		DeveTable.DeveTableIni();

		
		//研究所を半透明にするかどうかの判定
		DeveActiveDirector.DeveLaboActiveChecker();


		
	}

	
	
	
}
