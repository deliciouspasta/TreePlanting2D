using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabButtonController : MonoBehaviour {
	
	void Start () {
			
		MyButton.SetActiver("TabButtonBack",false);
		MyButton.SetActiver("YesButton",false);
		MyButton.SetActiver("NoButton",false);
		MyButton.SetActiver("UruButton",false);
		MyButton.SetActiver("BuyButton",false);
		
	}
	
}
