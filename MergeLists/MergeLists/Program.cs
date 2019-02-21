using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList l1 = new MyList();
            l1.AddLast(22);
            l1.AddLast(24);
            l1.AddLast(26);
            Console.WriteLine($"Список l1 - {l1}");

            MyList l2 = new MyList();
            l2.AddLast(11);
            l2.AddLast(13);
            l2.AddLast(15);

            Console.WriteLine($"Список l2 - {l2}");

            var l3 = l1 + l2;


            Console.WriteLine($"Список l3 - {l3}");
            

        }






    }
}
