using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidoriController : MonoBehaviour {


	//一億本を超えたスクエアの緑の画像を見つけ出し、表示する。アプリ起動時にも呼び出す。「更新」ボタンでも作ってこのかんすうよびだすものあり。
	public static void MidoriAppear(int i, bool b){
 
		string midoristr = "M (" + i.ToString() + ")";
		

		foreach(Transform midoriChild in StaticRocker.MidoriHolding.transform){
			if(midoriChild.name == midoristr){
				midoriChild.gameObject.SetActive(b);
				return;
			}
		}




		
	}

	
}
