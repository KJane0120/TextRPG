using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class StartGame
    {
        public void Start()
        {


            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요");

            //1,2,3 중에 입력받기
            while (true)
            {
                Console.Write(">> ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int num) && (num == 1 || num == 2 || num == 3))
                {
                    switch (num)
                    {
                        case 1:
                            Console.WriteLine("상태보기로 이동합니다.");
                            new ViewStatus().ShowStatus();
                            break;
                        case 2:
                            Console.WriteLine("인벤토리로 이동합니다.");
                            new Inventory().OpenInventory();
                            break;
                        case 3:
                            Console.WriteLine("상점으로 이동합니다.");
                            new Store().OpenStore();
                            break;
                    }
                    break; // 올바른 입력을 받으면 루프 탈출
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 1, 2, 3 중에 입력해주세요.");
                }
            }

        }
    }
}
