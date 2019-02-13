using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<decimal> st = new MyStack<decimal>();

            MyQueue<int> q = new MyQueue<int>(15);

            //st.Push(100);
            //st.Push(2000);

            //Console.WriteLine(st.Pop());
            
            //st.Push(303.5m);
            //st.Push(333.33m);


            q.Push(10);
            q.Push(20);
            q.Push(30);

            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());

            q.Push(40);
            q.Push(50);
            q.Push(60);

            //while (!st.IsEmpty)
            //{
            //    Console.WriteLine( st.Pop());
            //}
            // st.Push("abc");

            //Console.WriteLine();
            while (!q.IsEmpty)
            {
                Console.WriteLine(q.Pop());
            }

            

        }
    }
}
