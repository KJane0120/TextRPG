using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{

    internal class Inventory
    {
        Item item = new Item();


        public void OpenInventory()
        {
            Console.WriteLine();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            if (item != null)
            {
                item.ShowMyItem();
            }
            else
            {
                Console.Write("[아이템 목록]\n ");
            }
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
                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("메인 화면으로 이동합니다.");
                        StartGame startgame = new StartGame();
                        startgame.Start();
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
