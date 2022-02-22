using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShopStatic : MonoBehaviour {

	//注：たぶのひひょうじは　ShopTabSetter　で。


	public static GameObject _camera;


	//ShopScene のタブ
	public static GameObject tradeExplainTab;
	public static GameObject tradeTab;
	public static GameObject longPushTab;
	public static GameObject confirmTab;

	//トレードのUIてきな画像
	public static GameObject tradeImage;

	//ShopCoin,RainbowUIを格納しておくためのやつ
	public static GameObject ShopCoinObject;
	public static GameObject ShopRainbowObject;

	//トレード延べ棒のUIを格納しておくための奴
	public static GameObject TradeRainbowObject;

	//トレードの仮想的コイン残高の表示UI
	public static GameObject TradeVirtualCoinObject;
	

	//植林日誌タブ
	public static GameObject[] shopTreeExplainTab = new GameObject[20];
	public static GameObject[] shopHumanExplainTab = new GameObject[20];
	public static GameObject[] shopLaboExplainTab = new GameObject[10];

	//三角ボタンのGameObject
	/*public static GameObject[] triUpButtons = new GameObject[7];
	public static GameObject[] triDownButtons = new GameObject[7]; */

	//日誌タブの背景
	public static GameObject backImageDiary;

	//これはタブの種類（４種類）を表す
	public static int shopTabNumber = 0;

	//これはタブの種類に関係なく現在のタブが何層目かを表す
	public static int shopNowTabNumber = 0;

	//現在選択されている木と人間と研究所の番号を保持するだけ
	public static int shopSelectedTree = 0;
	public static int shopSelectedHuman = 0;
	public static int shopSelectedLabo = 0;

	//現在の日誌番号
	public static int shopNowDiaryTreeNumber = 0;

	//現在のヒトの日誌番号
	public static int shopNowDiaryHumanNumber = 0;
	//現在の研究所の日誌（便宜）番号
	public static int shopNowDiaryLaboNumber = 0;

	//トレードする虹の延べ棒の数
	public static long willTradeRainbow = 0;

	//現在選択されている木と人間の　値段　を保持するだけ
	public static long nowTreePrice = 0;
		//これは選択されてる奴の買い取り時の延べ棒
	public static long nowTreePriceRainbow = 0;
	
	public static long nowHumanPriceCoin = 0;
		//支払いが延べ棒のとき
	public static long nowHumanPriceRainbow = 0;

	//現在選択されている研究所の　値段　を保持するだけ
	public static long nowLaboPriceRainbow = 0;

	//木や人材の値段表
	public static long[] shopTreePriceDictionary = new long[20]; 
	public static long[] shopTreePriceDictionaryRain = new long[20];

	public static long[] shopHumanPriceDictionary = new long[20];
	public static long[] shopHumanPriceDictionaryRain = new long[20];

	public static long[] shopLaboPriceDictionaryRain = new long[10];

	

	//トレードで仮想的なコインを算出する割と重要な変数
	//public static float virtualCoin = 0;


	//購入前の確認画面で表示するための木と人間と研究所の画像表示
	public static GameObject[] shopTree = new GameObject[20];
	public static GameObject[] shopHuman = new GameObject[20];
	public static GameObject[] shopLabo = new GameObject[10];

	//コインを使うのか延べ棒をつかうのか
	public static bool isCoin;
	public static bool isRainbow;

	//木の日誌が表示されているかどうか
	public static bool isTreeDiary;

	//ヒトの日誌が表示されているかどうか
	public static bool isHumanDiary;
	
	//研究所の日誌（便宜）が表示されているかどうか
	public static bool isLaboDiary;

	
	
}

