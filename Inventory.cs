using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{

    internal class Inventory : Item
    {




        public void OpenInventory()
        {
            Console.WriteLine();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            //굳이 필요 없는 코드
            //if (mine != null)
            //{
            //    mine.MyItemList();
            //}
            //else
            //{
            //    Console.Write("[아이템 목록] ");
            //}
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");



            while (true)
            {

                string input = Console.ReadLine();
                Console.WriteLine();

                bool isValid = int.TryParse(input, out int num) && (num == 1 || num == 0);

                if (isValid)
                {
                    if (num == 1)
                    {
                        Console.WriteLine("장착 관리로 이동합니다.");
                        EquipItem();
                        return;

                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("메인 화면으로 이동합니다.");
                        StartGame.Start();
                        return;
                    }

                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 1, 0 중에 입력해주세요.");
                }


            }

        }

        public void EquipItem()
        {
            Console.WriteLine();
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            //ItemList();
            for (int i = 0; i < mine.myItems.Count; i++)
            {
                Console.Write($"- ");
                items[i].ShowItemInfo(true);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine();
                bool isValid = int.TryParse(input, out int num) && (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 || num == 6 || num == 0);
                if (isValid)
                {
                    if (num == 0)
                    {
                        Console.WriteLine("인벤토리로 돌아갑니다.");
                        OpenInventory();
                        return;
                    }
                    else 
                    { //해제 기능 추가해야 함
                        Console.WriteLine("아이템을 장착했습니다.");
                        Item.isEquiped = true;
                        Console.WriteLine();
                        Console.WriteLine("원하시는 행동을 입력해주세요.");
                        Console.Write(">> ");
                        continue;
                    }
                }
                //아이템에 없는 경우 장착 불가능 처리를 못함
                else if(!isValid || num > mine.myItems.Count)
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine();
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">> ");
                    continue;
                }
            }
        }


    }
}
