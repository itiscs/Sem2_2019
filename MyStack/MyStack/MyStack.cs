using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    class MyStack<T>
    {
        private readonly T[] mas;
        private int ind = -1;
        private readonly int maxL;

        public MyStack(int maxLength)
        {
            maxL = maxLength;
            mas = new T[maxL];
        }

        public MyStack():this(256)
        {
        }

        public bool IsEmpty
        {
            get
            {
                return ind == -1;
            }
        }

        public void Push(T info)
        {
            if(ind+1 >= maxL)
                throw new Exception("Stack is full");

            ind++;
            mas[ind] = info;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("Stack is empty");
            
            return mas[ind--];
        }

    }
}
