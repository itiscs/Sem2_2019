using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Elem
    {
        public int Info { get; set; }
        public Elem Next { get; set; }
    }

    
    class MyList
    {
        public Elem First { get; set; }

        public void AddFirst(int x)
        {
            var elem = new Elem();
            elem.Info = x;
            elem.Next = First;
            First = elem;
        }

        public void AddLast(int x)
        {
            if (First == null)
                AddFirst(x);
            else
            {
                var elem = First;
                while (elem.Next != null)
                    elem = elem.Next;
                elem.Next = new Elem() { Info = x };
            }
        }

        public void DeleteFirst()
        {
            if(First != null)
                First = First.Next;
                                 
        }

        public void DeleteLast()
        {
            if (First == null) //список пустой
                return;
            if (First.Next == null)//список состоит из одного эл
            {
                First = null;
                return;
            }
            var elem = First;
            while(elem.Next.Next != null) //ищем предпоследний элемент
            {
                elem = elem.Next;
            }
            elem.Next = null; 
        }



        public void Show()
        {
            var elem = First;
            while(elem != null)
            {
                Console.Write($"{elem.Info} -> ");
                elem = elem.Next;
            }
            Console.WriteLine("null");

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var elem = First;
            while (elem != null)
            {
                sb.Append($"{elem.Info} -> ");
                elem = elem.Next;
            }
            sb.Append("null");

            return sb.ToString();
        }



    }
}
