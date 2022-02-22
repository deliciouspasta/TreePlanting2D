using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPriceTable : MonoBehaviour {

	public static void PriceTableIni(){
		//木の場合
		ShopStatic.shopTreePriceDictionary[1] = 9000000;
		ShopStatic.shopTreePriceDictionary[2] = 42000000;
		ShopStatic.shopTreePriceDictionary[3] = 77000000;
		ShopStatic.shopTreePriceDictionary[4] = 357000000;
		ShopStatic.shopTreePriceDictionary[5] = 667000000;
		ShopStatic.shopTreePriceDictionary[6] = 3125000000;
		ShopStatic.shopTreePriceDictionary[7] = 5882000000;
		ShopStatic.shopTreePriceDictionary[8] = 7700000000;
		ShopStatic.shopTreePriceDictionary[9] = 2600000000;
		ShopStatic.shopTreePriceDictionary[10] = 0;
		ShopStatic.shopTreePriceDictionary[11] = 6100000000;
		ShopStatic.shopTreePriceDictionary[12] = 2700000000;
		ShopStatic.shopTreePriceDictionary[13] = 0;

		ShopStatic.shopTreePriceDictionaryRain[8] = 2;
		ShopStatic.shopTreePriceDictionaryRain[9] = 5;
		ShopStatic.shopTreePriceDictionaryRain[10] = 25;
		ShopStatic.shopTreePriceDictionaryRain[11] = 47;
		ShopStatic.shopTreePriceDictionaryRain[12] = 227;
		ShopStatic.shopTreePriceDictionaryRain[13] = 1000;

		//人材の場合
		ShopStatic.shopHumanPriceDictionary[1] = 5000000;
		ShopStatic.shopHumanPriceDictionary[2] = 10000000;
		ShopStatic.shopHumanPriceDictionary[3] = 50000000;
		ShopStatic.shopHumanPriceDictionary[4] = 100000000;
		ShopStatic.shopHumanPriceDictionary[5] = 400000000;
		ShopStatic.shopHumanPriceDictionary[6] = 700000000;

		ShopStatic.shopHumanPriceDictionaryRain[7] = 1;
		ShopStatic.shopHumanPriceDictionaryRain[8] = 3;
		ShopStatic.shopHumanPriceDictionaryRain[9] = 15;
		ShopStatic.shopHumanPriceDictionaryRain[10] = 30;
		ShopStatic.shopHumanPriceDictionaryRain[11] = 50;
		ShopStatic.shopHumanPriceDictionaryRain[12] = 300;
		ShopStatic.shopHumanPriceDictionaryRain[13] = 500;


		//研究所の場合
		ShopStatic.shopLaboPriceDictionaryRain[1] = 3;
		ShopStatic.shopLaboPriceDictionaryRain[2] = 30;
		ShopStatic.shopLaboPriceDictionaryRain[3] = 300;
		ShopStatic.shopLaboPriceDictionaryRain[4] = 3000;
		ShopStatic.shopLaboPriceDictionaryRain[5] = 30000;
		



	}
}
