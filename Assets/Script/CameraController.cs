using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {


	Camera _camera;

	
	Vector3 posi;
	
	
	float orthographicSizeConstant = 5.0f;

	
	public static bool isKitaAmericaFlag = false;
	public static bool isMinamiAmericaFlag = false;
	public static bool isYurashiaFlag = false;
	public static bool isAfricaFlag = false;
	public static bool isOseaniaFlag = false;
	public static bool isGoneTabFlag = false;

	
	void Start () {
		_camera = GetComponent<Camera>();
		
		posi = _camera.gameObject.transform.position;  //カメラの座標取得
		
	}
	
	



	public void OnMouseClickedKitaAmerica(){
		if(!StaticRocker.isZoomed){
			//自分の大陸以外はfalse
			isKitaAmericaFlag = true;
			isAfricaFlag = false;
			isYurashiaFlag = false;
			isMinamiAmericaFlag = false;
			isOseaniaFlag = false;
		}else{
			return;
		}
		

		StaticRocker.isZoomed = true;
		if(!isGoneTabFlag){
			_camera.gameObject.transform.position = new Vector3(-3,1.1f,-10);      //カメラを瞬間移動させる
			_camera.orthographicSize = 2.5f;
			MyButton.SetActiver("BackButton",true);
			MyButton.SetActiver("TitleButton", false);

			//shopに行けるボタンを非表示
			MyButton.SetActiver("ShopButton",false);
			//Deveに行けるボタンを非表示
			MyButton.SetActiver("DeveButton",false);

			//タブを適切な位置に動かしておく
			TabSeter.TabMover();

			Debug.Log("SEIKOU");
		}
	}

	
	public void OnMouseClickedAfrica(){
		if(!StaticRocker.isZoomed){
			//自分の大陸以外はfalse
			isKitaAmericaFlag = false;
			isAfricaFlag = true;
			isYurashiaFlag = false;
			isMinamiAmericaFlag = false;
			isOseaniaFlag = false;
		}else{
			return;
		}

		StaticRocker.isZoomed = true;
		if(!isGoneTabFlag){
			_camera.gameObject.transform.position = new Vector3(1.5f,-1.8f,-10);      //カメラを瞬間移動させる
			_camera.orthographicSize = 2.5f;
			MyButton.SetActiver("BackButton",true);
			MyButton.SetActiver("TitleButton", false);

			//shopに行けるボタンを非表示
			MyButton.SetActiver("ShopButton",false);
			//Deveに行けるボタンを非表示
			MyButton.SetActiver("DeveButton",false);

			//タブを適切な位置に動かしておく
			TabSeter.TabMover();

			Debug.Log("SEIKOU");
		}
	}

	public void OnMouseClickedYurashia(){
		if(!StaticRocker.isZoomed){
			//自分の大陸以外はfalse
			isKitaAmericaFlag = false;
			isAfricaFlag = false;
			isYurashiaFlag = true;
			isMinamiAmericaFlag = false;
			isOseaniaFlag = false;
		}else{
			return;
		}

		StaticRocker.isZoomed = true;
		if(!isGoneTabFlag){
			_camera.gameObject.transform.position = new Vector3(4.5f,0.5f,-10);      //カメラを瞬間移動させる
			_camera.orthographicSize = 2.5f;
			MyButton.SetActiver("BackButton",true);
			MyButton.SetActiver("TitleButton", false);

			//shopに行けるボタンを非表示
			MyButton.SetActiver("ShopButton",false);
			//Deveに行けるボタンを非表示
			MyButton.SetActiver("DeveButton",false);

			//タブを適切な位置に動かしておく
			TabSeter.TabMover();

			Debug.Log("SEIKOU");
		}
	}

	public void OnMouseClickedMinamiAmerica(){
		if(!StaticRocker.isZoomed){
			//自分の大陸以外はfalse
			isKitaAmericaFlag = false;
			isAfricaFlag = false;
			isYurashiaFlag = false;
			isMinamiAmericaFlag = true;
			isOseaniaFlag = false;
		}else{
			return;
		}

		StaticRocker.isZoomed = true;
		if(!isGoneTabFlag){
			_camera.gameObject.transform.position = new Vector3(-2.5f,-2.8f,-10);      //カメラを瞬間移動させる
			_camera.orthographicSize = 2.5f;
			MyButton.SetActiver("BackButton",true);
			MyButton.SetActiver("TitleButton", false);

			//shopに行けるボタンを非表示
			MyButton.SetActiver("ShopButton",false);
			//Deveに行けるボタンを非表示
			MyButton.SetActiver("DeveButton",false);

			//タブを適切な位置に動かしておく
			TabSeter.TabMover();

			Debug.Log("SEIKOU");
		}
	}

	public void OnMouseClickedOseania(){
		if(!StaticRocker.isZoomed){
			//自分の大陸以外はfalse
			isKitaAmericaFlag = false;
			isAfricaFlag = false;
			isYurashiaFlag = false;
			isMinamiAmericaFlag = false;
			isOseaniaFlag = true;
		}else{
			return;
		}

		StaticRocker.isZoomed = true;
		if(!isGoneTabFlag){
			_camera.gameObject.transform.position = new Vector3(7.0f,-3.0f,-10);      //カメラを瞬間移動させる
			_camera.orthographicSize = 2.5f;
			MyButton.SetActiver("BackButton",true);
			MyButton.SetActiver("TitleButton", false);

			//shopに行けるボタンを非表示
			MyButton.SetActiver("ShopButton",false);
			//Deveに行けるボタンを非表示
			MyButton.SetActiver("DeveButton",false);

			//タブを適切な位置に動かしておく
			TabSeter.TabMover();

			Debug.Log("SEIKOU");
		}
	}

//大陸ズームイン状態からズームアウトにする
	public void Back(){
		if(!isGoneTabFlag){
			_camera.gameObject.transform.position = posi;
			_camera.orthographicSize = orthographicSizeConstant;
			MyButton.SetActiver("BackButton",false);
			MyButton.SetActiver("TitleButton",true);
			isKitaAmericaFlag = false;
			isMinamiAmericaFlag = false;
			isYurashiaFlag = false;
			isAfricaFlag = false;
			isOseaniaFlag = false;

			//もうズーム状態ではなくなる
			StaticRocker.isZoomed = false;

			//shopに行けるボタンを表示
			MyButton.SetActiver("ShopButton",true);
			//Deveに行けるボタンを表示
			MyButton.SetActiver("DeveButton",true);
		}
	}

	
}
