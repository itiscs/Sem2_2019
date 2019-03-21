using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Phone
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id}  {Brand}    {Model}     {Price}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone()
            {
                Id = 1,
                Brand = "a",
                Model = "zz",
                Price = 10000m
            });
            phones.Add(new Phone()
            {
                Id = 2,
                Brand = "ka",
                Model = "dzz dddd",
                Price = 22000m
            }); phones.Add(new Phone()
            {
                Id = 3,
                Brand = "ma",
                Model = "hzz",
                Price = 77000m
            }); phones.Add(new Phone()
            {
                Id = 4,
                Brand = "fa",
                Model = "zz dddd",
                Price = 9000m
            }); phones.Add(new Phone()
            {
                Id = 5,
                Brand = "pa",
                Model = "dzz dddfsf",
                Price = 90000m
            });

            var newLst = phones.Where(p => p.Price > 10000).OrderByDescending(p => p.Model)
                .ThenByDescending(p => p.Price).Select(p => new { p.Brand, p.Model } );


            var lst2 = phones.SelectMany(p => p.Model.Split(' ')).Distinct();

            //Console.WriteLine(phones.Min(p => p.Model));
            
            //Console.WriteLine(newLst);
            foreach (var p in lst2)
            {
                Console.WriteLine(p);
            }
            

        }
    }
}









