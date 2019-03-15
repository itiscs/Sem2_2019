using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateApp
{


    class ArOper
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Min(int a, int b)
        {
            return a - b;
        }
        public int Prod(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }

        public void Hello1()
        {
            Console.WriteLine("Hello 1");
        }
        public void Hello2()
        {
            Console.WriteLine("Hello 2");
        }
    }



    class Program
    {
        delegate int MyOper(int a, int b);

        
        
        static void Main(string[] args)
        {
            ArOper ar = new ArOper();
            Func<int, int, int> myOper = new Func<int, int, int>(ar.Div);
            Action myAction = new Action(ar.Hello1);

            myAction += ar.Hello1;

            myAction?.Invoke();

            myOper = (a, b) => a + b;
            
            //Console.WriteLine(myOper(17, 8));


            int x = myOper(5, 10);

            List<int> lst = new List<int>() { 2,5,6,7,9,3,4,6,7,8};

            var str = Console.ReadLine();

            var newLst = lst.Where(k => k % 2 == 0).OrderBy(k => -k).Take(3);

            Console.WriteLine(newLst.Count());

            lst.Sort();

            foreach (var elem in newLst)
            {
                Console.WriteLine(elem);
            }



            //Console.WriteLine("Hello World!");
        }
    }
}
