using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskThreadApp
{
    class Program
    {
        static int N = 8000000, kol = 4;
        static int[] a = new int[N];

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Thread.CurrentThread.Name = "Main";
            //Thread t1 = new Thread(func);
            //t1.Name = "Second";

            //t1.Start();

            //Thread.Sleep(100);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Поток {Thread.CurrentThread.Name} выводит " + i.ToString());
            //    Thread.Sleep(100);
            //}

            Random r = new Random();
            for (int i = 0; i < N; i++)
            {

                a[i] = r.Next();

            }

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int sump = 0;
            for (int i = 0; i < N; i++)
            {
                sump += a[i];
            }
            timer.Stop();
            var time1 = timer.ElapsedMilliseconds;

            timer.Restart();


            Task<int> t1 = new Task<int>(FuncSum);
            Task<int> t2 = new Task<int>(FuncSum);
            Task<int> t3 = new Task<int>(FuncSum);
            Task<int> t4 = new Task<int>(FuncSum);


            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            //Task.WaitAll();
            var sum = t1.Result + t2.Result + t3.Result + t4.Result;

            
            timer.Stop();
            var time2 = timer.ElapsedMilliseconds;

            Console.WriteLine($"Разница сумм - {sum-sump} ");
            Console.WriteLine($"посл - {time1} с тасками - {time2} ");
            






        }

        static void func()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Поток {Thread.CurrentThread.Name} выводит " + i.ToString());
                Thread.Sleep(100);
            }
        }

        static int FuncSum()
        {
            int k = N / kol, sum = 0;
            int id = Convert.ToInt32(Task.CurrentId) - 1;
            int i1 = k * id;
            int i2 = k * (id + 1);
            Console.WriteLine($"{id} - {i1} - {i2}");

            for (int i = i1; i < i2; i++)
                sum += a[i];// Console.Write($"{i} from thread 1\n");
            return sum;
        }



    }
}
