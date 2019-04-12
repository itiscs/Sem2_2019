using System;
using System.Collections.Generic;
using System.Text;

namespace SearchTree
{
    public class Elem
    {
        public int Info { get; set; }
        public Elem Left { get; set; }
        public Elem Right { get; set; }
    }
    class SearchTree
    {
       private Elem Root { get; set; }

       
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


            public string Leveled()
            {
                StringBuilder sb = new StringBuilder();
                Queue<Elem> q1 = new Queue<Elem>();
                Queue<Elem> q2;
                if (Root != null)
                    q1.Enqueue(Root);
                int k = 0;

                while (q1.Count > 0)
                {
                    sb.Append($"Level {k++}: ");

                    q2 = new Queue<Elem>();
                    while (q1.Count > 0)
                    {
                        var el = q1.Dequeue();
                        if (el.Left != null)
                            q2.Enqueue(el.Left);
                        if (el.Right != null)
                            q2.Enqueue(el.Right);
                        sb.Append($"{el.Info} ");
                    }
                    sb.Append("\n");
                    q1 = q2;
                }

                return sb.ToString();
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                Stack<Elem> st = new Stack<Elem>();
                st.Push(Root);

                while (st.Count > 0)
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



        public void AddElem(int x)
        {
            if (Root == null)
            {
                Root = new Elem() { Info = x };
                return;
            }

            var t = Root;
            while (t != null)
            {
                if (x < t.Info)
                {
                    if (t.Left == null)
                    {
                        t.Left = new Elem() { Info = x };
                        return;
                    }
                    else
                        t = t.Left;
                }
                else if (t.Info < x )
                {
                    if (t.Right == null)
                    {
                        t.Right = new Elem() { Info = x };
                        return;
                    }
                    else
                        t = t.Right;
                }
                else
                    return;
            }
        }

        public bool Contains(int x)
        {
            var t = Root;
            while(t != null)
            {
                if (t.Info == x)
                    return true;
                if (t.Info > x)
                    t = t.Left;
                else
                    t = t.Right;
            }
            return false;
        }


    }
}

