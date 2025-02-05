using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        static bool isBuying = false;
        public static bool isPurchased = false;
        public static bool isEquiped = false;
        //static 으로 다른 스크립트에서도 사용할 수 있도록 함
        static int i = 0;
        public static List<Item> items = new List<Item>();

        ViewStatus viewStatus = new ViewStatus();
        public static MyItem mine = new MyItem();


        public void ShowItemInfo(bool status)
        {
            //ItemList(); 를 넣었다가 무한루프의 지옥에서 한참을 헤맸다....

            if (itemStr == 0)
            {
                if (status)
                {
                    Console.Write($"{itemName}\t| 방어력 +{itemDef} | {itemDesc}\t| 구매완료");
                }
                else
                {
                    Console.Write($"{itemName}\t| 방어력 +{itemDef} | {itemDesc}\t| {itemPrice} G");
                }

            }
            else if (itemDef == 0)
            {
                if (status)
                {
                    Console.Write($"{itemName}\t| 공격력 +{itemStr} | {itemDesc}\t| 구매완료");
                }
                else
                {
                    Console.Write($"{itemName}\t| 방어력 +{itemStr} | {itemDesc}\t| {itemPrice} G");
                }
            }
        }

        public void ShowMyItem()
        {
            mine.MyItemList();
            if (itemStr == 0)
            {
                Console.Write($"{itemName}\t| 방어력 +{itemDef} | {itemDesc}");
            }
            else if (itemDef == 0)
            {
                Console.Write($"{itemName}\t| 공격력 +{itemStr} | {itemDesc}");
            }

        }
        public static void ItemList()
        {

            items.Clear(); // 아이템 목록을 초기화하고 다시 추가하는 방식으로 수정
            items.Add(new Item() { itemName = "수련자 갑옷", itemStr = 0, itemDef = +5, itemDesc = "수련에 도움을 주는 갑옷입니다.", itemPrice = 1000 });
            items.Add(new Item() { itemName = "무쇠 갑옷", itemStr = 0, itemDef = +9, itemDesc = "무쇠로 만들어져 튼튼한 갑옷입니다.", itemPrice = 1800 });
            items.Add(new Item() { itemName = "스파르타의 갑옷", itemStr = 0, itemDef = +15, itemDesc = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", itemPrice = 3500 });
            items.Add(new Item() { itemName = "낡은 검", itemStr = +2, itemDef = 0, itemDesc = "쉽게 볼 수 있는 낡은 검입니다.", itemPrice = 600 });
            items.Add(new Item() { itemName = "청동 도끼", itemStr = +5, itemDef = 0, itemDesc = "어디선가 사용됐던거 같은 도끼입니다.", itemPrice = 1500 });
            items.Add(new Item() { itemName = "스파르타의 창", itemStr = +7, itemDef = 0, itemDesc = "스파르타의 전사들이 사용했다는 전설의 창입니다.", itemPrice = 2100 });

            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");


            //구매 여부 - 상점/아이템 구매 창 여부 - 인벤토리/장착 관리창 여부
            //if (items.Count != 0)
            //{
            //    for (i = 0; i < items.Count; i++)
            //    {
            //        Console.Write($"{i + 1}. ");
            //        items[i].ShowItemInfo();
            //        Console.WriteLine();
            //    }

            if (isPurchased == true)
            {

                //string purchased = itemPrice.ToString();
                //purchased = "구매완료";


                //내가 지금까지 구매한 아이템
                for (i = 0; i < mine.myItems.Count; i++)
                {
                    Console.Write($"- {i + 1}. ");
                    items[i].ShowItemInfo(true);
                    Console.WriteLine();
                }
                // 아이템 리스트에서 특정 아이템을 가져와 사용
                //Item selectedItem = items[i]; 
                //string purchased = selectedItem.itemPrice.ToString(); // 올바른 접근 방법
                //purchased = "구매완료";
                // => 이렇게 하면 구매완료가 출력되지 않음. ShowItemInfo() 메서드에서 status를 받아서 출력해야 함

                if (isBuying == true)//이미 구매됐고, 상점에서 아이템 구매창을 열었을 때
                {
                    for (i = 0; i < items.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        items[i].ShowItemInfo(false);
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (isEquiped == true)//이미 구매됐고, 상점에서 아이템 구매창을 연게 아니고, 장착됐을 때
                    {

                        Console.Write($"- {i + 1} [E]");

                        mine.MyItemList();

                        Console.WriteLine();

                    }
                    else//이미 구매됐고, 상점에서 아이템 구매창을 연게 아니고, 장착되지 않았을 때
                    {
                        for (i = 0; i < mine.myItems.Count; i++)
                        {
                            Console.Write($"- {i + 1} ");
                            mine.MyItemList();
                            Console.WriteLine();
                        }
                    }

                }

            }

            else
            {

                if (isBuying == true)//구매돼있지 않고, 상점에서 아이템 구매창을 열었을 때
                {
                    //돌아와서 확인해볼 것
                    //Console.WriteLine(mine.myItems.Count); 
                    for (i = 0; i < items.Count; i++)
                    {
                        Console.Write($"- {i + 1} ");
                        items[i].ShowItemInfo(false);
                        Console.WriteLine();
                    }
                }
                else//구매돼있지 않고, 인벤토리에서 아이템 목록을 열었을 때
                {
                    //for (i = 0; i < items.Count; i++)
                    //{
                    //    Console.Write($"- ");
                    //    myitems[i].ShowItemInfo();
                    //    Console.WriteLine();
                    //}
                    mine.MyItemList();
                }

            }
            //}
            //else
            //{
            //    Console.WriteLine("아이템이 없습니다.");
            //}
        }



        public void BuyItem()
        {
            MyItem myitems = new MyItem();

            isBuying = true;


            Console.WriteLine();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{viewStatus.gold} G");

            ItemList();

            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");

            while (true)
            {

                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int num) && (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 0);
                Console.WriteLine();
                if (isValid)
                {
                    if (!isPurchased)
                    {
                        switch (num)//재화 감소, 인벤토리에 아이템 추가, 상점에 구매완료 표시
                        {

                            case 1:
                                Console.WriteLine("구매를 완료했습니다.");
                                viewStatus.gold -= 1000;
                                mine.AddItem(items[0]);
                                isPurchased = true;
                                break;
                            case 2:
                                Console.WriteLine("구매를 완료했습니다.");
                                viewStatus.gold -= 1800;
                                mine.AddItem(items[1]);
                                isPurchased = true;
                                break;
                            case 3:
                                Console.WriteLine("구매를 완료했습니다.");
                                viewStatus.gold -= 3500;
                                mine.AddItem(items[2]);
                                isPurchased = true;
                                break;
                            case 4:
                                Console.WriteLine("구매를 완료했습니다.");
                                viewStatus.gold -= 600;
                                mine.AddItem(items[3]);
                                isPurchased = true;
                                break;
                            case 5:
                                Console.WriteLine("구매를 완료했습니다.");
                                viewStatus.gold -= 1500;
                                mine.AddItem(items[4]);
                                isPurchased = true;
                                break;
                            case 6:
                                Console.WriteLine("구매를 완료했습니다.");
                                viewStatus.gold -= 2100;
                                mine.AddItem(items[5]);
                                isPurchased = true;
                                break;

                        }
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        Console.Write(">> ");
                        continue;
                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("메인 화면으로 돌아갑니다.");
                        StartGame.Start();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("이미 구매한 아이템입니다.");
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        Console.Write(">> ");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">> ");
                }

            }









        }
    }
    internal class MyItem
    {
        public List<Item> myItems = new List<Item>();
        public void AddItem(Item item)
        {
            myItems.Add(item);
        }

        public void MyItemList()
        {
            for (int i = 0; i < myItems.Count; i++)
            {
                //장착 여부에 따라 이름 앞에 [E]를 붙이거나 빼는 if문 구성
                Console.Write($"{i + 1}. ");
                myItems[i].ShowMyItem();
                Console.WriteLine();
            }
        }

    }


}
