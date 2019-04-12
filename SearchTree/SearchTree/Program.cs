using System;

namespace SearchTree
{



    class Program
    {
        static void Main(string[] args)
        {
            SearchTree st = new SearchTree();

            st.AddElem(5);
            st.AddElem(2);
            st.AddElem(8);
            st.AddElem(6);
            st.AddElem(2);
            st.AddElem(1);
            st.AddElem(7);
            st.AddElem(10);

            st.Show();
        }
    }
}
