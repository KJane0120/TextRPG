using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Store
    {
        public void OpenStore()
        {
            ViewStatus viewStatus = new ViewStatus();
            Item item = new Item();

            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{viewStatus.gold}");

            item.ItemList();



        }




    }
}
