using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    class Elem
    {
        public int Info { get; set; }
        public Elem Next { get; set; }
    }

    class MyList
    {
        public Elem First { get; set; }

        public int Length
        {
            get
            {
                int k = 0;
                var el = First;
                while (el != null)
                {
                    k++;
                    el = el.Next;
                }
                return k;
            }
        }

        public void AddFirst(int x)
        {
            var el = new Elem() { Info = x, Next = First };
            First = el;
        }

        public void AddLast(int x)
        {
            var el = First;
            if (el == null)
            {
                AddFirst(x);
                return;
            }
            while (el.Next != null)
                el = el.Next;
            el.Next = new Elem() { Info = x };
        }

        public override string ToString()
        {
            var el = First;
            var sb = new StringBuilder();
            while(el!=null)
            {
                sb.Append($"{el.Info} ");
                el = el.Next;
            }
            return sb.ToString();
        }

        public bool IsOrdered()
        {
            var el = First;
            if (el == null || el.Next == null)
                return true;
            while(el.Next != null)
            {
                if (el.Info > el.Next.Info)
                    return false;
                el = el.Next;
            }
            return true;
        }



        public static MyList operator+ (MyList l1, MyList l2)
        {
            if (!l1.IsOrdered() || !l2.IsOrdered())
                throw new Exception("Списки не упорядочены");

            var el1 = l1.First;
            var el2 = l2.First;
            var l3 = new MyList();

            while(el1!=null && el2!=null)
            {
                if (el1.Info < el2.Info)
                {
                    l3.AddLast(el1.Info);
                    el1 = el1.Next;
                }
                else
                {
                    l3.AddLast(el2.Info);
                    el2 = el2.Next;
                }
            }
            if(el1 == null)
                while(el2 != null)
                {
                    l3.AddLast(el2.Info);
                    el2 = el2.Next;
                }
            else
                while (el1 != null)
                {
                    l3.AddLast(el1.Info);
                    el1 = el1.Next;
                }

            return l3;


        }

        public static MyList operator *(MyList l1, MyList l2)
        {
            //Пересечение упорядоченных списков

            return new MyList();

        }

        public static MyList operator -(MyList l1, MyList l2)
        {
            //Разность упорядоченных списков l1 - l2
            return new MyList();
        }




    }
}
