using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTree t = new MyTree("(1,(2,3,(4,,8)),(5,6,7))");
            t.Show(); //рекурсивный обход
            Console.WriteLine();
            Console.WriteLine(t); //обход при помощи стека
            Console.WriteLine(t.Leveled()); //обход при помощи очереди
        }
    }
}
