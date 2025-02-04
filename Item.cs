using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{

    internal class Item
    {
        public string itemName;
        public int itemStr;
        public int itemDef;
        public string itemDesc;
        public int itemPrice;

        public void ShowItemInfo()
        {
            if (itemStr == 0)
            {
                Console.Write($"{itemName}\t| 방어력 +{itemDef} | {itemDesc}\t|{itemPrice} G");
            }
            else if (itemDef == 0)
            {
                Console.Write($"{itemName}\t| 공격력 {itemStr} | {itemDesc}\t|{itemPrice} G");
            }
            else
                Console.Write($"{itemName}\t| 공격력 {itemStr} | 방어력 {itemDef} | {itemDesc}\t|{itemPrice} G");
        }

        public void ShowMyItem()
        {
            if (itemStr == 0)
            {
                Console.Write($"{itemName}\t| 방어력 +{itemDef} | {itemDesc}");
            }
            else if (itemDef == 0)
            {
                Console.Write($"{itemName}\t| 공격력 +{itemStr} | {itemDesc}");
            }
            else if (itemStr != 0 && itemDef != 0)
            {
                Console.Write($"{itemName}\t| 공격력 +{itemStr} | 방어력 +{itemDef} | {itemDesc}");
            }

        }
        public void ItemList()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { itemName = "수련자 갑옷", itemStr = 0, itemDef = +5, itemDesc = "수련에 도움을 주는 갑옷입니다.", itemPrice = 1000 });
            items.Add(new Item() { itemName = "무쇠 갑옷", itemStr = 0, itemDef = +9, itemDesc = "무쇠로 만들어져 튼튼한 갑옷입니다.", itemPrice = 1800 });
            items.Add(new Item() { itemName = "스파르타의 갑옷", itemStr = 0, itemDef = +15, itemDesc = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", itemPrice = 3500 });
            items.Add(new Item() { itemName = "낡은 검", itemStr = +2, itemDef = 0, itemDesc = "쉽게 볼 수 있는 낡은 검입니다.", itemPrice = 600 });
            items.Add(new Item() { itemName = "청동 도끼", itemStr = +5, itemDef = 0, itemDesc = "어디선가 사용됐던거 같은 도끼입니다.", itemPrice = 1500 });
            items.Add(new Item() { itemName = "스파르타의 창", itemStr = +7, itemDef = 0, itemDesc = "스파르타의 전사들이 사용했다는 전설의 창입니다.", itemPrice = 2100 });

            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < items.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                items[i].ShowItemInfo();
                Console.WriteLine();
            }
        }



    }
}
