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
            //MyList<int> l1 = new MyList<int>();
            //l1.AddLast(22);
            //l1.AddLast(24);
            //l1.AddLast(26);
            //Console.WriteLine($"Список l1 - {l1}");

            //MyList<int> l2 = new MyList<int>();
            //l2.AddLast(11);
            //l2.AddLast(13);
            //l2.AddLast(15);

            //MyList<string> l1 = new MyList<string>();
            //l1.AddLast("aaaa");
            //l1.AddLast("gggg");
            //l1.AddLast("kkkk");
            //Console.WriteLine($"Список l1 - {l1}");

            //MyList<string> l2 = new MyList<string>();
            //l2.AddLast("bbbbbb");
            //l2.AddLast("hhhhhhh");
            //l2.AddLast("zzzzzz");



            MyList<Student> l1 = new MyList<Student>();
            l1.AddLast(new Student() { id = 1, Name = "aaaa", Marks = { 2, 3, 4, 3 } });
            l1.AddLast(new Student() { id = 11, Name = "bbbbb", Marks = { 3, 3, 4, 3 } });
            l1.AddLast(new Student() { id = 21, Name = "fffff", Marks = { 5, 5, 5, 3 } });
            Console.WriteLine($"Список l1 - {l1}");


            MyList<Student> l2 = new MyList<Student>();
            l2.AddLast(new Student() { id = 15, Name = "llll", Marks = { 2, 2, 2, 3 } });
            l2.AddLast(new Student() { id = 14, Name = "kkkk", Marks = { 2, 3, 4, 3 } });
            l2.AddLast(new Student() { id = 13, Name = "cccc", Marks = { 5, 5, 4, 5 } });
           

            Console.WriteLine($"Список l2 - {l2}");

            var l3 = l1 + l2;


            Console.WriteLine($"Список l3 - {l3}");
            

        }






    }
}
