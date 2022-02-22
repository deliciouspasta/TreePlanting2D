using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveActiveDirector : MonoBehaviour {

	//研究所群の半透明を管理
	public static void DeveLaboActiveChecker(){
		for(int i = 1; i < 6; i++){
			if(StaticRocker.isLaboBought[i]){
				DeveMyButton.DeveInteractablerLaboSelf("DeveLaboButton ("+i.ToString()+")",true);
				Debug.Log(StaticRocker.isLaboBought[i]);
				
			}else{
				DeveMyButton.DeveInteractablerLaboSelf("DeveLaboButton ("+i.ToString()+")",false);
				Debug.Log(StaticRocker.isLaboBought[i]);
			}
		}
	}

	//開発するためのアイテムの半透明や「開発済み」の管理
	public static void ActiveItemChecker(){

		if(DeveStatic.NowLaboNumber == 1){


			//所持している延べ棒の数が開発費を上回っていたらボタンを反応可能にする
			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[1] && !StaticRocker.isDeved[1]){
				DeveMyButton.DeveInteractablerLabo("Takumi",true);

			}else if(StaticRocker.isDeved[1]){
				DeveMyButton.DeveInteractablerLabo("Takumi",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[1].SetActive(true);

			}else{
				DeveMyButton.DeveInteractablerLabo("Takumi",false);
				
			}

			

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[2] && !StaticRocker.isDeved[2]){
				DeveMyButton.DeveInteractablerLabo("Gijutsu",true);
			}else if(StaticRocker.isDeved[2]){
				DeveMyButton.DeveInteractablerLabo("Gijutsu",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[2].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Gijutsu",false);
			}

		}

		if(DeveStatic.NowLaboNumber == 2){

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[3] && !StaticRocker.isDeved[3]){
				DeveMyButton.DeveInteractablerLabo("Mukishitsu",true);
			}else if(StaticRocker.isDeved[3]){
				DeveMyButton.DeveInteractablerLabo("Mukishitsu",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[3].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Mukishitsu",false);
			}

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[4] && !StaticRocker.isDeved[4]){
				DeveMyButton.DeveInteractablerLabo("Hainetsu",true);
			}else if(StaticRocker.isDeved[4]){
				DeveMyButton.DeveInteractablerLabo("Hainetsu",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[4].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Hainetsu",false);
			}

		}

		if(DeveStatic.NowLaboNumber == 3){

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[5] && !StaticRocker.isDeved[5]){
				DeveMyButton.DeveInteractablerLabo("Eichi",true);
			}else if(StaticRocker.isDeved[5]){
				DeveMyButton.DeveInteractablerLabo("Eichi",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[5].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Eichi",false);
			}

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[6] && !StaticRocker.isDeved[6]){
				DeveMyButton.DeveInteractablerLabo("MegamiTsukai",true);
			}else if(StaticRocker.isDeved[6]){
				DeveMyButton.DeveInteractablerLabo("MegamiTsukai",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[6].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("MegamiTsukai",false);
			}

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[7] && !StaticRocker.isDeved[7]){
				DeveMyButton.DeveInteractablerLabo("DaichiTsukai",true);
			}else if(StaticRocker.isDeved[7]){
				DeveMyButton.DeveInteractablerLabo("DaichiTsukai",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[7].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("DaichiTsukai",false);
			}

		}

		if(DeveStatic.NowLaboNumber == 4){

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[8] && !StaticRocker.isDeved[8]){
				DeveMyButton.DeveInteractablerLabo("Kane",true);
			}else if(StaticRocker.isDeved[8]){
				DeveMyButton.DeveInteractablerLabo("Kane",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[8].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Kane",false);
			}

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[9] && !StaticRocker.isDeved[9]){
				DeveMyButton.DeveInteractablerLabo("Ego",true);
			}else if(StaticRocker.isDeved[9]){
				DeveMyButton.DeveInteractablerLabo("Ego",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[9].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Ego",false);
			}

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[10] && !StaticRocker.isDeved[10]){
				DeveMyButton.DeveInteractablerLabo("Kuro",true);
			}else if(StaticRocker.isDeved[10]){
				DeveMyButton.DeveInteractablerLabo("Kuro",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[10].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Kuro",false);
			}

		}

		if(DeveStatic.NowLaboNumber == 5){

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[11] && !StaticRocker.isDeved[11]){
				DeveMyButton.DeveInteractablerLabo("Antei",true);
			}else if(StaticRocker.isDeved[11]){
				DeveMyButton.DeveInteractablerLabo("Antei",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[11].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Antei",false);
			}

			if(StaticRocker.RainbowHolder >= DeveStatic.deveTable[12] && !StaticRocker.isDeved[12]){
				DeveMyButton.DeveInteractablerLabo("Kamikara",true);
			}else if(StaticRocker.isDeved[12]){
				DeveMyButton.DeveInteractablerLabo("Kamikara",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[12].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Kamikara",false);
			}


			//ここだけ条件が特殊
			if(StaticRocker.isAllPlanted && !StaticRocker.isDeved[13]){
				DeveMyButton.DeveInteractablerLabo("Izanagi",true);
			}else if(StaticRocker.isDeved[13]){
				DeveMyButton.DeveInteractablerLabo("Izanagi",false);
				//「開発済み」画像を表示する
				DeveStatic.devedIgames[13].SetActive(true);
			}else{
				DeveMyButton.DeveInteractablerLabo("Izanagi",false);
			}

		}

	}
}
