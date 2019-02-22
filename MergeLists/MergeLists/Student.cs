using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeLists
{
    public class Student:IComparable
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public int CompareTo(object obj)
        {
            Student st = (Student)obj;

            return Marks.Average().CompareTo(st.Marks.Average());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{id} {Name} :");
            foreach (var m in Marks)
                sb.Append($"{m} ");

            return sb.ToString();
        }

    }
}
