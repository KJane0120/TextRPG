using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    
    internal class ViewStatus
    {
        //프로퍼티를 이용해 각 수치들을 저장하고 출력할 수 있도록 할것
        int lv = 1;
        public int str = 10;
        public int def = 5;
        int hp = 100;
        public int gold = 1500;

        public void ShowStatus()
        {
            Console.WriteLine();
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv. {lv}");
            Console.WriteLine("Chad (전사)");
            Console.WriteLine($"공격력 : {str}");
            Console.WriteLine($"방어력 : {def}");
            Console.WriteLine($"체력 : {hp}");
            Console.WriteLine($"Gold : {gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");
            



            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine();

                bool isValid = int.TryParse(input, out int num) && num == 0;
                if (isValid)
                {
                    Console.WriteLine("메인화면으로 돌아갑니다.");
                    
                    StartGame.Start();
                    return;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 0을 입력해주세요.");
                }
            }
        }

        class Program
        {
            static void Status()
            {

            }
        }


    }



}
