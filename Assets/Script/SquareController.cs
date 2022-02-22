using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour {

	
	GameObject SquareHolding;
	

	void Start () {
		
		SquareHolding = GameObject.Find("SquareHolding");
		
	}
	
	//スクエアの表示、非表示を外から管理する。余裕があるならboolでまず判定させた方が良い
	void Update () {        
		if(CameraController.isKitaAmericaFlag||CameraController.isMinamiAmericaFlag||CameraController.isYurashiaFlag||CameraController.isAfricaFlag||CameraController.isOseaniaFlag){
			foreach(Transform squareChild in SquareHolding.transform){
				squareChild.gameObject.SetActive(true);
			}
		}else{
			foreach(Transform squareChild in SquareHolding.transform){
				squareChild.gameObject.SetActive(false);
			}
		}
		
		
	}

	
}
