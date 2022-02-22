using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeveStatic : MonoBehaviour {

	public static GameObject deveComfirmTab;
	public static GameObject deveFinTab;
	public static GameObject DeveRainbowObject;
	
	//研究所ごとのホルダーを格納する
	public static GameObject[] laboCanHolders = new GameObject[6];

	//確認用の研究所の画像を格納
	public static GameObject[] deveLabo = new GameObject[6];

	//研究所の説明画像を格納
	public static GameObject[] deveLaboExplain = new GameObject[6];

	//「開発済み」　画像を格納
	public static GameObject[] devedIgames = new GameObject[20];

	//確認画面で表示する開発アイテムの画像を格納
	public static GameObject[] deveItem = new GameObject[20];
	
	
	//現在開発されようとしている開発番号
	public static int NowDeveItemNumber = 0;

	//現在の研究所番号
	public static int NowLaboNumber = 0;

	//現在の研究所の　説明　番号
	public static int NowLaboExplainNumber = 0;

	//現在のタブ番号
	public static int NowDeveTabNumber = 0;
	
	//開発費表
	public static long[] deveTable = new long[20];

	public static bool isLaboExplain;

	
}
