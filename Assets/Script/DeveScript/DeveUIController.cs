using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveUIController : MonoBehaviour {

	//DeveSceneでの虹の延べ棒残高を表示
	public static void DeveDisplayRainbowUI(){
		Text deveRainbowText = DeveStatic.DeveRainbowObject.GetComponent<Text>();
		deveRainbowText.text = "虹の延べ棒：" + StaticRocker.RainbowHolder.ToString("N0");
	}
}
