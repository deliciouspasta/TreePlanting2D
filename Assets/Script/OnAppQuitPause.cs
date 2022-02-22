using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAppQuitPause : MonoBehaviour {

	void OnApplicationQuit(){

		//SaveData.Instance.SampleArray = StaticRocker.isSquareActive;

		StaticRocker.isGameFin = true;
		
		SaveData.Instance.Substitutioner();

		SaveData.Instance.Save();

		for(int i = 0; i < 200; i++){
			if(StaticRocker.isSquareActive[i]){
				Debug.Log(i + "isSquareActive true");
				Debug.Log(SaveData.Instance.isSquareActive[i]);
			}
		}

		Debug.Log("OnAppQuit");
		Debug.Log("treeInfobreed11 "+ StaticRocker.treeInfo[11].breed);
		
		
	}

	void OnApplicationPause(bool b){
		if(b){

			StaticRocker.isGameFin = true;

			SaveData.Instance.Substitutioner();
			SaveData.Instance.Save();

			Debug.Log("OnAppPause");

			
		}
		

	}
}
