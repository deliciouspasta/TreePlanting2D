using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapToDeve : MonoBehaviour {

	public void OnClicked(){
		//伊弉諾を開発可能か判定
		AllPlantedCheckDirector.AllPlantedChecker();
		
		SceneManager.LoadScene("DeveScene");

		
		
	}
}
