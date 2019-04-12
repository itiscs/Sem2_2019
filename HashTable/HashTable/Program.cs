using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            HashSet<int> hs = new HashSet<int>();

            string s = "Hello world!";


            dict[s.GetHashCode() % 100] = s;
            //Console.WriteLine(s.GetHashCode() % 100);

            s = "Hello world";
            dict[s.GetHashCode() % 100] = s;
            //Console.WriteLine(s.GetHashCode()%100);

            s = "";
            dict[s.GetHashCode() % 100] = s;
            //Console.WriteLine(s.GetHashCode()%100);





        }
    }
}
