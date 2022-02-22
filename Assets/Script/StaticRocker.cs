using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//＊＊＊このオブジェクトとスクリプトはどうやら一番最後（時間的に）にアタッチしないとうまく動作しないらしい
public class StaticRocker : MonoBehaviour {

	public static GameObject _camera;

	//ミドリホールディング（緑の画像群が入ってるGameObject）
	public static GameObject MidoriHolding;

	
	public static GameObject tab1;
	public static GameObject tab2;
	public static GameObject tab3;
	public static GameObject tab4;


	//植林後のスクエアに開くタブ
	public static GameObject tabA1;
	public static GameObject tabA2;

	
	


	public static GameObject tabbuttonback;

	//植林前の確認画面での木と人間の画像表示
	public static GameObject[] treeItem = new GameObject[20];
	public static GameObject[] humanItem = new GameObject[20];

	//植林するときに開く木と人材の個数を表示するためのUI
	public static GameObject[] allTreeNumberUI = new GameObject[20];
	public static GameObject[] allHumanNumberUI = new GameObject[20];

	// SquareUIDirector	で用いる(UI)
	public static GameObject treeAmount = null;
	public static GameObject coinAmount = null;
	public static GameObject nowcointreeUI = null;

	//植林前の確認画面での木と人間をもつホールディングスを保持する
	public static GameObject treeHolding;
	public static GameObject humanHolding;

	//アイテムが存在しないときに表示する画像
	public static GameObject pleaseBuyImage;


	//たぶん植林選択中にその木のボタンを表示するかどうかの判定用
	public static bool[] isTree = new bool[20];
	public static bool[] isHuman = new bool[20];

	//研究所が購入されたかどうか
	public static bool[] isLaboBought = new bool[10];

	//まっさらなスクエアに植林手続きをしている間のみtrueとなる
	public static bool[] isSquareBool = new bool[200];

	//アプリが起動したときにこのスクエアは稼働中かどうかを調べる
	public static bool[] isSquareActive = new bool[200];

	//植林中かどうかを調べる
	public static bool[] isPlanting = new bool[200];

	//繁殖数が1億を超えたかどうかを調べる
	public static bool[] isBreedFinish = new bool[200];

	//このアイテムは開発済みかどうか
	public static bool[] isDeved = new bool[20];

	//スクエアクリック可能かどうか（タブが出てるかどうか）(どちらの場合でも使用される)
	public static bool isCanSquareClick = true;

	//タップで大陸にズームが行ってるかどうか
	public static bool isZoomed;

	//すべてのスクエアが植林完了状態（ミドリの草が表示されている状態）になっているか
	public static bool isAllPlanted;

	 //一番最初に起動したときは代入が起きないようにするためのフラグ
 	public static bool isSecond = false;

	 //ゲームを閉じてないのにシーン間遷移だけで代入が起きてしまわないようにするためのフラグ
	public static bool isGameFin = false;

	


	//あとで戻しとく3600に
	public static long ONEHOUR = 3;

	//後で戻しとく86400．0ｆに
	public static long ONEDAY = 86400;

	//どのスクエアの木を売却するか(tabA)
	public static bool[] isSellSquare = new bool[200];
	

	public struct TreeInfo{
		
		public double breed;
		public long sellingPrice;
		public long treeHonsuu;
		
	}

	public struct HumanInfo{
		public long plantSpeed;
			
	}

	



	

//各スクエアが持つtree情報を入れるための箱
	public static TreeInfo[] treeInfo = new TreeInfo[200]; 
	public static HumanInfo[] humanInfo = new HumanInfo[200];

	//売却時にコインホルダーに入る金額
	public static long[] realSellingPrice = new long[200];

	//アプリ起動時にも参照される
	public static long[] startTime = new long[200];

	//Update関数で毎回更新（ただしこのとき配列全走査はダメ）。アプリ終了時も更新。
	public static long[] endTime = new long[200];
	public static long[] diffTime = new long[200];

	//植林の人材が１３番目かどうか（１３なら１００万が代入される）
	public static long[] momentHuman13 = new long[200];

	//植えられた木が１３番目かどうか（１３なら１億が代入される）
	public static long[] momentTree13 = new long[200];
	
	public static int treeReceiver = 0;
	public static int tabNumber = 0;
	public static int tabANumber = 0;

	//現在選択されているスクエアの番号
	public static int NowSquareNumber = 999;
	

	//現在選択されている木と人間の番号を保持するだけ。木はその後も使うので一つずつ保持
	public static int selectedTree = 0;
	public static int selectedHuman = 0;
	public static int[] selectedTreeS = new int[200];

	//木や人材のスタック（数）を格納
	public static int[] allTree = new int[20];
	public static int[] allHuman = new int[20];

	public static bool isTreeTab = false;


	//コインを格納する重要変数
	public static long CoinHolder = 538000000000000;
	
	
	//虹の延べ棒を格納する重要変数
	public static long RainbowHolder = 100000000;

	
	
	
	
	
}
