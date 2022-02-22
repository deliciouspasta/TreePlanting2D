using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartToMap : MonoBehaviour {

	GameObject earth;
	GameObject startButton;
	Color earthColor;
	Color startButtonColor;
	
	void Start (){
		earth = GameObject.Find("Earth");
		
		earthColor = earth.gameObject.GetComponent<Image>().color;

		startButton = GameObject.Find("startButton");
		startButtonColor = startButton.gameObject.GetComponent<Image>().color;
	}

	public void OnClicked(){
		
		StartCoroutine(FadeOuting());
		
		
	}

	public IEnumerator FadeOuting(){
		for(int i = 0; i < 20; i++){
			
			yield return new WaitForSeconds(0.1f);

			earthColor.a -= 0.05f;
			startButtonColor.a -= 0.05f;

			//注意！ここの再代入を忘れないように！
			earth.gameObject.GetComponent<Image>().color = earthColor;
			startButton.gameObject.GetComponent<Image>().color = startButtonColor;
		}

		//OnClickedでやるとfor文が終わる前に実行されてしまう
		SceneManager.LoadScene("MapScene");
	}
}
