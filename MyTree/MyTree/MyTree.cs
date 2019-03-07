using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class MyTree
    {
        private Elem Root { get; set; }

        public MyTree()
        {
            Root = new Elem()
            {
                Info = 1,
                Left = new Elem()
                {
                    Info = 2,
                    Left = new Elem() { Info = 4 },
                    Right = new Elem() { Info = 5 }
                },
                Right = new Elem()
                {
                    Info = 3,
                    Left = new Elem() { Info = 6 },
                    Right = new Elem() { Info = 7 }
                }
            };
        }

        private void ShowElem(Elem el)
        {
            if (el == null) return;
            if (el.Left == el.Right)
                Console.Write(el.Info);
            else
            {
                Console.Write($"({el.Info},");
                ShowElem(el.Left);
                Console.Write(",");
                ShowElem(el.Right);
                Console.Write(")");
            }
        }

        public void Show()
        {
            ShowElem(Root);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Stack<Elem> st = new Stack<Elem>();
            st.Push(Root);

            while(st.Count>0)
            {
                Elem t = st.Pop();
                if (t == null) continue;
                if (t.Left == t.Right)
                {
                    sb.Append(t.Info);
                    continue;
                }

                if (t.Right != null) st.Push(t.Right);
                if (t.Left != null) st.Push(t.Left);
                
                sb.Append(t.Info);

            }

            return sb.ToString();
        }






    }
}
