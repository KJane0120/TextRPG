﻿using System;
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

            int num;
            bool isValid;

            //입력받은 값이 1, 2, 3이 아니면 다시 입력받도록 하기
            do
            {
                Console.Write(">> ");

                string input = Console.ReadLine();
                isValid = int.TryParse(input, out num) && (num == 1 || num == 2 || num == 3);

                if (num == 1)
                {
                    Console.WriteLine("상태보기로 이동합니다.");
                    ViewStatus viewstatus = new ViewStatus();
                    viewstatus.ShowStatus();
                }
                else if (num == 2)
                {
                    Console.WriteLine("인벤토리로 이동합니다.");
                    Inventory inventory = new Inventory();
                    inventory.OpenInventory();
                    
                }
                else if (num == 3)
                {
                    Console.WriteLine("상점으로 이동합니다.");
                }
                else if (!isValid)
                {
                    Console.WriteLine("잘못된 입력입니다. 1, 2, 3 중에 입력해주세요.");
                }

            }
            while (!isValid);
            
        }
    }
}
