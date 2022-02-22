using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SquareUIDirector : MonoBehaviour {

	
	void Start () {
		
	}
	

	//UIで現在の状況を表示(まだ植林が終わってないときの現在の植林状況)
	public static void DisplayUI(long treeHonsuu){
		Text treeAmountText = StaticRocker.treeAmount.GetComponent<Text>();
		treeAmountText.text = "現在の本数：" + treeHonsuu.ToString("f0") + "\n";
	}

	//UIで植林完了後＆1億本達成後の現在の状況を表示
	public static void DisplayUI(long treeHonsuu, long sellingPrice ){
		Text treeAmountText = StaticRocker.nowcointreeUI.GetComponent<Text>();
		treeAmountText.text = "現在の本数：" + treeHonsuu + "\n" + "売価：" + sellingPrice;
	}
}
