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

            lst.AddLast(1);
            //lst.AddLast(2);
            //lst.AddLast(3);
            //lst.AddLast(4);
            //lst.AddLast(5);
            lst.AddLast(6);

            lst.DeleteFirst();
            lst.DeleteLast();

            Console.WriteLine(lst);


        }
    }
}
