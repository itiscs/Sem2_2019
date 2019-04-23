using System;
using System.Text;

namespace PriorityQueue
{
    class Elem
    {
        public int Task { get; set; }
        public int Priority { get; set; }

        public override string ToString()
        {
            return $"{Priority}:{Task}";
        }
    }

    class PriorityQueue
    {
        public int Capacity { get; private set; }
        private Elem[] data;

        public PriorityQueue(Elem[] inputData )
        {
            Capacity = inputData.Length;
            data = new Elem[2*Capacity];
            for(int i=0;i<Capacity;i++)
            {
                data[Capacity + i] = inputData[i]; 
            }
            FillQueue();
        }

        private void FillQueue()
        {
            for(int k = Capacity - 1; k>0; k--)
            {
                if (data[2 * k].Priority > data[2 * k + 1].Priority)
                    data[k] = data[2 * k];
                else
                    data[k] = data[2 * k + 1];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int k = 1; k < 2*Capacity; k++)
            {
                sb.AppendLine($"{k} -- {data[k]}");
            }
            return sb.ToString();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Elem[] data = { new Elem { Priority = 1, Task = 1 },
                            new Elem { Priority = 2, Task = 2 },
                            new Elem { Priority = 30, Task = 3 },
                            new Elem { Priority = 4, Task = 4 },
                            new Elem { Priority = 1, Task = 5 },
                            new Elem { Priority = 5, Task = 6 },
                            new Elem { Priority = 3, Task = 7 },
                            new Elem { Priority = 4, Task = 8 }};
            PriorityQueue queue = new PriorityQueue(data);

            Console.WriteLine(queue);
        }
    }
}
