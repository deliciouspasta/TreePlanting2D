//  SaveData.cs
//  http://kan-kikuchi.hatenablog.com/entry/Json_SaveData
//
//  Created by kan.kikuchi on 2016.11.21.

using UnityEngine;

using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

/// <summary>
/// クラスを丸ごとJsonで保存するデータクラス
/// </summary>
[Serializable]
public class SaveData : ISerializationCallbackReceiver {

  //シングルトンを実装するための実体、初アクセス時にLoadする。
  private static SaveData _instance = null;
  public  static SaveData  Instance{
    get{
      if(_instance == null){
        Load();
      }
      return _instance;
    }
  }

  //SaveDataをJsonに変換したテキスト(リロード時に何度も読み込まなくていいように保持)
  [SerializeField]
  private static string _jsonText = "";

  //=================================================================================
  //保存されるデータ(public or SerializeFieldを付ける)
  //=================================================================================


  //ここから
  //=====================================================================================
  
 

	//たぶん植林選択中にその木のボタンを表示するかどうかの判定用
	public bool[] isTree = new bool[20];
	public bool[] isHuman = new bool[20];

	//研究所が購入されたかどうか
	public bool[] isLaboBought = new bool[10];

	//まっさらなスクエアに植林手続きをしている間のみtrueとなる
	public bool[] isSquareBool = new bool[200];

	//アプリが起動したときにこのスクエアは稼働中かどうかを調べる
	public bool[] isSquareActive = new bool[200];

	//植林中かどうかを調べる
	public bool[] isPlanting = new bool[200];

	//繁殖数が1億を超えたかどうかを調べる
	public bool[] isBreedFinish = new bool[200];

  //このアイテムは開発済みかどうか
	public bool[] isDeved = new bool[20];

	

	//すべてのスクエアが植林完了状態（ミドリの草が表示されている状態）になっているか
	public bool isAllPlanted;

  public bool isSecond;
  public bool isGameFin;

	

  //木の構造体の代わり（保存できないので仕方なく）
  public double[] SaveTreeBreed = new double[200];
  public long[] SaveTreeSellingPrice = new long[200];
  public long[] SaveTreeHonsuu = new long[200];

  //ヒトの構造体の代わり（保存できないので仕方なく）
  public long[] SavePlantSpeed = new long[200];
	


	//売却時にコインホルダーに入る金額
	public long[] realSellingPrice = new long[200];

	//アプリ起動時にも参照される
	public long[] startTime = new long[200];

	//Update関数で毎回更新（ただしこのとき配列全走査はダメ）。アプリ終了時も更新。
	public long[] endTime = new long[200];
	public long[] diffTime = new long[200];

	//植林の人材が１３番目かどうか（１３なら１００万が代入される）
	public long[] momentHuman13 = new long[200];

	//植えられた木が１３番目かどうか（１３なら１億が代入される）
	public long[] momentTree13 = new long[200];
	
	

	
	

	//植林した木が確認できるようにするための奴
	public int[] selectedTreeS = new int[200];

	//木や人材のスタック（数）を格納
	public int[] allTree = new int[20];
	public int[] allHuman = new int[20];

	public bool isTreeTab = false;


	//コインを格納する重要変数
	public long CoinHolder = 538000000000000;
	
	
	//虹の延べ棒を格納する重要変数
	public long RainbowHolder = 100000000;

  //===============================================================================ここまで



  public int    SampleInt    = 10;
  public string SampleString = "Sample";
  public bool   SampleBool   = false;
  public bool[] SampleArray = new bool[200]; 

  public List<int> SampleIntList = new List<int>(){2, 3, 5, 7, 11, 13, 17, 19};

  [SerializeField]
  private string _sampleDictJson = "";
  public Dictionary<string, int> SampleDict = new Dictionary<string, int>(){
    {"Key1", 50},
    {"Key2", 150},
    {"Key3", 550}
  };

  //=================================================================================
  //シリアライズ,デシリアライズ時のコールバック
  //=================================================================================

  /// <summary>
  /// SaveData→Jsonに変換される前に実行される。
  /// </summary>
  public void OnBeforeSerialize(){
    //Dictionaryはそのままで保存されないので、シリアライズしてテキストで保存。
    _sampleDictJson = Serialize (SampleDict);
  }

  /// <summary>
  /// Json→SaveDataに変換された後に実行される。
  /// </summary>
  public void OnAfterDeserialize(){
    //保存されているテキストがあれば、Dictionaryにデシリアライズする。
    if(!string.IsNullOrEmpty(_sampleDictJson)){
      SampleDict = Deserialize<Dictionary<string, int>>(_sampleDictJson);
    }
  }

  //引数のオブジェクトをシリアライズして返す
  private static string Serialize<T> (T obj){
    BinaryFormatter binaryFormatter = new BinaryFormatter ();
    MemoryStream    memoryStream    = new MemoryStream ();
    binaryFormatter.Serialize (memoryStream , obj);
    return Convert.ToBase64String (memoryStream   .GetBuffer ());
  }

  //引数のテキストを指定されたクラスにデシリアライズして返す
  private static T Deserialize<T> (string str){
    BinaryFormatter binaryFormatter = new BinaryFormatter ();
    MemoryStream    memoryStream    = new MemoryStream (Convert.FromBase64String (str));
    return (T)binaryFormatter.Deserialize (memoryStream);
  }

  //=================================================================================
  //取得
  //=================================================================================

  /// <summary>
  /// データを再読み込みする。
  /// </summary>
  public void Reload(){
    JsonUtility.FromJsonOverwrite (GetJson(), this);
  }

  //データを読み込む。
  private static void Load(){
    _instance = JsonUtility.FromJson<SaveData>(GetJson ());
  }

  //保存しているJsonを取得する
  private static string GetJson(){
    //既にJsonを取得している場合はそれを返す。
    if(!string.IsNullOrEmpty(_jsonText)){
      return _jsonText;
    }

    //Jsonを保存している場所のパスを取得。
    string filePath = GetSaveFilePath();

    //Jsonが存在するか調べてから取得し変換する。存在しなければ新たなクラスを作成し、それをJsonに変換する。
    if(File.Exists(filePath)){
      _jsonText = File.ReadAllText (filePath);
    }
    else{
      _jsonText = JsonUtility.ToJson(new SaveData ());
    }

    return _jsonText;
  }

  //=================================================================================
  //保存
  //=================================================================================

  /// <summary>
  /// データをJsonにして保存する。
  /// </summary>
  public void Save(){
    _jsonText = JsonUtility.ToJson(this);
    File.WriteAllText (GetSaveFilePath(), _jsonText);
  }

  //=================================================================================
  //削除
  //=================================================================================

  /// <summary>
  /// データを全て削除し、初期化する。
  /// </summary>
  public void Delete(){
    _jsonText = JsonUtility.ToJson(new SaveData ());
    Reload ();
  }

  //=================================================================================
  //保存先のパス
  //=================================================================================

  //保存する場所のパスを取得。
  private static string GetSaveFilePath(){

    //string filePath = "Assets/SaveData";
    string filePath = "SaveData";

    //確認しやすいようにエディタではAssetsと同じ階層に保存し、それ以外ではApplication.persistentDataPath以下に保存するように。
    #if UNITY_EDITOR
    filePath += ".json";
    #else
    filePath = Application.persistentDataPath + "/" + filePath ;
    #endif

    

    return filePath;
    
  }


  //保存のために代入して取得する
  public void Substitutioner(){
    
  	//たぶん植林選択中にその木のボタンを表示するかどうかの判定用
  	isTree = StaticRocker.isTree;
  	isHuman = StaticRocker.isHuman;

  	//研究所が購入されたかどうか
  	isLaboBought = StaticRocker.isLaboBought;

  	//まっさらなスクエアに植林手続きをしている間のみtrueとなる
  	isSquareBool = StaticRocker.isSquareBool;

  	//アプリが起動したときにこのスクエアは稼働中かどうかを調べる
	  isSquareActive = StaticRocker.isSquareActive;

  	//植林中かどうかを調べる
  	isPlanting = StaticRocker.isPlanting;

  	//繁殖数が1億を超えたかどうかを調べる
  	isBreedFinish = StaticRocker.isBreedFinish;

    //このアイテムは開発済みかどうか
    isDeved = StaticRocker.isDeved;

    isSecond = StaticRocker.isSecond;
    isGameFin = StaticRocker.isGameFin;

  	//すべてのスクエアが植林完了状態（ミドリの草が表示されている状態）になっているか
  	isAllPlanted = StaticRocker.isAllPlanted;

    //各スクエアが持つtree情報を入れるための箱
    for(int i = 0; i < 200; i++){
       

        SaveTreeBreed[i] = StaticRocker.treeInfo[i].breed;
        SaveTreeSellingPrice[i] = StaticRocker.treeInfo[i].sellingPrice;
        SaveTreeHonsuu[i] = StaticRocker.treeInfo[i].treeHonsuu;

        SavePlantSpeed[i] = StaticRocker.humanInfo[i].plantSpeed;

    }
  	

  	//売却時にコインホルダーに入る金額
    realSellingPrice = StaticRocker.realSellingPrice;

  	//アプリ起動時にも参照される
  	startTime = StaticRocker.startTime;

  	//Update関数で毎回更新（ただしこのとき配列全走査はダメ）。アプリ終了時も更新。
  	endTime = StaticRocker.endTime;
 	  diffTime = StaticRocker.diffTime;

	  //植林の人材が１３番目かどうか（１３なら１００万が代入される）
	  momentHuman13 = StaticRocker.momentHuman13;

	  //植えられた木が１３番目かどうか（１３なら１億が代入される）
	  momentTree13 = StaticRocker.momentTree13;

    //何の木を植林したのか確認できるようにするための奴
    selectedTreeS = StaticRocker.selectedTreeS;

	  //木や人材のスタック（数）を格納
	  allTree = StaticRocker.allTree;
	  allHuman = StaticRocker.allHuman;

	  isTreeTab = StaticRocker.isTreeTab;


	  //コインを格納する重要変数
	  CoinHolder = StaticRocker.CoinHolder;
	
	
	  //虹の延べ棒を格納する重要変数
	  RainbowHolder = StaticRocker.RainbowHolder;

  }

  public void StartSubstitutioner(){
      //たぶん植林選択中にその木のボタンを表示するかどうかの判定用
  	StaticRocker.isTree = isTree;
  	StaticRocker.isHuman = isHuman;

  	//研究所が購入されたかどうか
  	StaticRocker.isLaboBought = isLaboBought;

  	//まっさらなスクエアに植林手続きをしている間のみtrueとなる
  	StaticRocker.isSquareBool = isSquareBool;

  	//アプリが起動したときにこのスクエアは稼働中かどうかを調べる
	  StaticRocker.isSquareActive = isSquareActive;

  	//植林中かどうかを調べる
  	StaticRocker.isPlanting = isPlanting;

  	//繁殖数が1億を超えたかどうかを調べる
  	StaticRocker.isBreedFinish = isBreedFinish;

    //このアイテムは開発済みかどうか
    StaticRocker.isDeved　= isDeved;

    StaticRocker.isSecond = isSecond;
    StaticRocker.isGameFin = isGameFin;

  	//すべてのスクエアが植林完了状態（ミドリの草が表示されている状態）になっているか
  	StaticRocker.isAllPlanted = isAllPlanted;

    //各スクエアが持つtree情報を入れるための箱
    for(int i = 0; i < 200; i++){

        StaticRocker.treeInfo[i].breed = SaveTreeBreed[i];
        StaticRocker.treeInfo[i].sellingPrice = SaveTreeSellingPrice[i];
        StaticRocker.treeInfo[i].treeHonsuu = SaveTreeHonsuu[i];

        StaticRocker.humanInfo[i].plantSpeed = SavePlantSpeed[i];
    }
  	

  	//売却時にコインホルダーに入る金額
    StaticRocker.realSellingPrice = realSellingPrice;

  	//アプリ起動時にも参照される
  	StaticRocker.startTime = startTime;

  	//Update関数で毎回更新（ただしこのとき配列全走査はダメ）。アプリ終了時も更新。
  	StaticRocker.endTime = endTime;
 	  StaticRocker.diffTime = diffTime;

	  //植林の人材が１３番目かどうか（１３なら１００万が代入される）
	  StaticRocker.momentHuman13 = momentHuman13;

	  //植えられた木が１３番目かどうか（１３なら１億が代入される）
	  StaticRocker.momentTree13 = momentTree13;

    //何の木を植林したのか確認できるようにするための奴
    StaticRocker.selectedTreeS = selectedTreeS;

	  //木や人材のスタック（数）を格納
	  StaticRocker.allTree = allTree;
	  StaticRocker.allHuman = allHuman;

	  StaticRocker.isTreeTab = isTreeTab;


	  //コインを格納する重要変数
	  StaticRocker.CoinHolder = CoinHolder;
	
	
	  //虹の延べ棒を格納する重要変数
	  StaticRocker.RainbowHolder = RainbowHolder;
  }

  public void GameFinSecondChecker(){
    StaticRocker.isGameFin = isGameFin;
    StaticRocker.isSecond = isSecond;
  }



}