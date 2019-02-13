using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class MyQueue<T>
    {
        private readonly T[] mas;
        private int beg = 0;
        private int end = -1;
        private readonly int maxL;

        public MyQueue(int maxLength)
        {
            maxL = maxLength;
            mas = new T[maxL];
        }

        public bool IsEmpty
        {
            get
            {
                return beg > end;
            }
        }

        public void Push(T info) // Enqueue
        {
            mas[++end] = info;
        }

        public T Pop() // Dequeue
        {
            if (IsEmpty)
                throw new Exception("Queue is empty");

            return mas[beg++];

        }






    }
}
