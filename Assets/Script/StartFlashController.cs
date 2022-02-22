using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFlashController : MonoBehaviour {

	//ゆっくり点滅するスクリプト
	Color _color;
	float alpha_Sin;
	
	void Start () {
		_color = this.gameObject.GetComponent<Image>().color;
	}

	
	void Update () {
		alpha_Sin = Mathf.Sin(2*Time.time) / 0.5f + 0.50f;
		_color.a = alpha_Sin;
		this.gameObject.GetComponent<Image>().color = _color;
	} 

	
}
