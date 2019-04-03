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
                    Right = new Elem() { Info = 5,
                        Left =new Elem() { Info = 8 } }
                },
                Right = new Elem()
                {
                    Info = 3,
                    Left = new Elem() { Info = 6 },
                    Right = new Elem() { Info = 7 }
                }
            };
        }

        public MyTree(string str)
        {
            // (1,(2,4,(5,8,)),(3,6,7))
            int k = 0;
            Root = Create(str.Split(new char[] { ',', ')' }), ref k);

        }

        private Elem Create(String[] str, ref int k)
        {
            Elem t = new Elem();
            if (!str[k].Contains('('))
            {
                t.Info = int.Parse(str[k]);
            }
            else
            {
                t.Info = int.Parse(str[k].Remove(0, 1));//убрали '(' 
                k++;
                if (str[k] != "")
                    t.Left = Create(str, ref k);
                k++;
                if (str[k] != "")
                    t.Right = Create(str, ref k);
                k++;
            }
            return t;
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


        public string Leveled()
        {
            StringBuilder sb = new StringBuilder();
            //Queue<Elem> q = new Queue<Elem>();
            //q.Enqueue(Root);

            //while(q.Count > 0)
            //{
            //    var el = q.Dequeue();
            //    if (el != null)
            //    {
            //        q.Enqueue(el.Left);
            //        q.Enqueue(el.Right);
            //        sb.Append($"{el.Info} ");
            //    }
            //}

            Queue<Elem> q1 = new Queue<Elem>();
            Queue<Elem> q2;
            if(Root!=null)
                q1.Enqueue(Root);
            int k = 0;
            
            while (q1.Count > 0)
            {
                sb.Append($"Level {k++}: ");

                q2 = new Queue<Elem>();
                while (q1.Count > 0)
                {
                    var el = q1.Dequeue();
                    if(el.Left!=null)
                        q2.Enqueue(el.Left);
                    if(el.Right!=null)
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
