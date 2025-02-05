using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Store : Item
    {
        public void OpenStore()
        {
            ViewStatus viewStatus = new ViewStatus();
            Item item = new Item();

            Console.WriteLine();
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{viewStatus.gold} G");

            ItemList();
            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
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
                        Console.WriteLine("아이템 구매로 이동합니다.");
                        item.BuyItem();
                        return;
                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("메인 화면으로 돌아갑니다.");
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
    }
}
