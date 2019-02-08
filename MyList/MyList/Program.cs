using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList lst = new MyList();
            lst.AddFirst(1);
            lst.AddFirst(2);
            lst.AddFirst(3);

            Console.WriteLine(lst.Length);
            Console.WriteLine(lst);

            lst.AddFirst(4);
            lst.AddFirst(5);
            lst.AddFirst(6);
            lst.AddFirst(7);

            Console.WriteLine(lst.Length);
            Console.WriteLine(lst);


        }
    }
}
