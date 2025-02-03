using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{

    internal class Inventory
    {
        public void OpenInventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine();
            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.Write(">> ");

            bool isValid;
            do
            {
                string input = Console.ReadLine();
                int num = int.Parse(input);
                isValid = int.TryParse(input, out num) && (num == 1 || num == 0);

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
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 1, 0 중에 입력해주세요.");
                    }
                }

            }
            while (!isValid);
        }
    }
}
