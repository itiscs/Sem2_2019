﻿using System;
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

        public int Length
        {
            get
            {
                int k = 0;
                var el = First;
                while(el != null)
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var el = First;
            while( el != null)
            {
                sb.Append($"{el.Info} ");
                el = el.Next;
            }
            return sb.ToString();
        }


    }
}
