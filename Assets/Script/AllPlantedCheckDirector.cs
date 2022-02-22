using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlantedCheckDirector : MonoBehaviour {

	public static void AllPlantedChecker(){
		for(int i = 0; i < 79; i++){
			if(StaticRocker.isSquareActive[i] && StaticRocker.isBreedFinish[i]){

			}else{
				StaticRocker.isAllPlanted = false;
				return;
			}
		}

		StaticRocker.isAllPlanted = true;
	}
}
