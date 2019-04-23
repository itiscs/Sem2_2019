using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateApp
{


    class ArOper
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Min(int a, int b)
        {
            return a - b;
        }
        public static int Prod(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static void Hello1()
        {
            Console.WriteLine("Hello 1");
        }
        public static void Hello2()
        {
            Console.WriteLine("Hello 2");
        }
    }

    class Phone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id}  {Brand}    {Model}     {Price}";
        }
    }



    class Program
    {
        delegate int MyOper(int a, int b);
        delegate void MyHello();       
        
        static void Main(string[] args)
        {
            Func<int,int,int> myOper = new Func<int, int, int>(ArOper.Sum);

            //MyOper myOper = new MyOper(ArOper.Sum);

            Console.WriteLine(myOper(2, 5));

            myOper = (a,b) => a * b;

            Console.WriteLine(myOper(2, 5));

            myOper = ArOper.Div;

            Action delegHello = new Action(ArOper.Hello1);

            //delegHello();

            delegHello += ArOper.Hello1;
            delegHello += ArOper.Hello2;
            delegHello += () => { Console.WriteLine("Hello from lambda"); };

            delegHello?.Invoke();

            //myOper = (a,b) => a + b; 


            //Console.WriteLine(myOper(14, 7));


            //myOper = ArOper.Min;


            //Action hello = new Action(ArOper.Hello1);

            //hello += ArOper.Hello2;
            //hello += () => { Console.WriteLine("Hello from lambda"); };

            //hello?.Invoke();

            Console.WriteLine("*********************************");

            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone()
            {
                Id = 1,
                Brand = "a",
                Model = "zz",
                Price = 10000m
            });
            phones.Add(new Phone()
            {
                Id = 2,
                Brand = "ka",
                Model = "dzz",
                Price = 22000m
            }); phones.Add(new Phone()
            {
                Id = 3,
                Brand = "ma",
                Model = "hzz",
                Price = 77000m
            }); phones.Add(new Phone()
            {
                Id = 4,
                Brand = "ka",
                Model = "zz",
                Price = 9000m
            }); phones.Add(new Phone()
            {
                Id = 5,
                Brand = "pa",
                Model = "dzz",
                Price = 90000m
            });



            var newLst = phones.Where(p => p.Price > 10000).
                OrderBy(p => p.Price).Select(p => new { p.Brand, p.Model });

            foreach (var elem in newLst)
            {
                Console.WriteLine(elem);
            }



            ////ArOper ar = new ArOper();
            ////Func<int, int, int> myOper = new Func<int, int, int>(ar.Div);
            ////Action myAction = new Action(ar.Hello1);

            ////myAction += ar.Hello1;

            ////myAction?.Invoke();

            ////myOper = (a, b) => a + b;

            //////Console.WriteLine(myOper(17, 8));


            ////int x = myOper(5, 10);

            //List<int> lst = new List<int>() { 2, 5, 6, 7, 9, 3, 4, 6, 7, 8 };

            //var newLst = lst.Where(k => k % 2 == 1).OrderByDescending(k=>k).FirstOrDefault(k=>k%13==0);

            //Console.WriteLine(newLst);
            //foreach (var elem in newLst)
            //{
            //    Console.WriteLine(elem);
            //}



            ////Console.WriteLine("Hello World!");

            //List<int> tasks = new List<int>();
            //for (int i = 1; i <= 100; i++)
            //    tasks.Add(i);

            //List<int> studs = new List<int>();
            //for (int k = 1; k <= 27; k++)
            //{
            //    Console.Write($"stud {k} --- ");
            //    if (k < 10)
            //        foreach (int i in tasks.Where(x => x % 10 == k))
            //            Console.Write($"{i} ");
            //    else if (k < 21)
            //        foreach (int i in tasks.Where(x => x % 11 == k - 10))
            //            Console.Write($"{i} ");
            //    else
            //        foreach (int i in tasks.Where(x => x % 12 == k - 20))
            //            Console.Write($"{i} ");

            //    Console.WriteLine();

            //}







        }
    }
}
