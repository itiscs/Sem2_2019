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

    class Shop
    {
        public int Id { get; set; }
        public string Address { get; set; }
        
        public override string ToString()
        {
            return $"{Id}  {Address}";
        }
    }

    class Presents
    {
        public int ShopId { get; set; }
        public int PhoneId { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{ShopId}  {PhoneId} {Amount}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Shop> shops = new List<Shop>();
            shops.Add(new Shop() { Id = 1, Address = "Address 1" });
            shops.Add(new Shop() { Id = 2, Address = "Address 2" });
            shops.Add(new Shop() { Id = 3, Address = "Address 3" });

            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone()
            {
                Id = 1,
                Brand = "iPhone",
                Model = "X",
                Price = 80000m
            });
            phones.Add(new Phone()
            {
                Id = 2,
                Brand = "iPhone",
                Model = "XR",
                Price = 60000m
            }); phones.Add(new Phone()
            {
                Id = 3,
                Brand = "iPhone",
                Model = "XS",
                Price = 90000m
            }); phones.Add(new Phone()
            {
                Id = 4,
                Brand = "Samsung",
                Model = "S10E",
                Price = 60000m
            }); phones.Add(new Phone()
            {
                Id = 5,
                Brand = "Samsung",
                Model = "S9",
                Price = 50000m
            }); phones.Add(new Phone()
            {
                Id = 6,
                Brand = "Xiaomi",
                Model = "Pocophone F1",
                Price = 40000m
            }); phones.Add(new Phone()
            {
                Id = 7,
                Brand = "Xiaomi",
                Model = "Mi 9",
                Price = 30000m
            });

            List<Presents> pres = new List<Presents>();
            pres.Add(new Presents() { ShopId = 1, PhoneId = 1, Amount = 15 });
            pres.Add(new Presents() { ShopId = 2, PhoneId = 3, Amount = 6 });
            pres.Add(new Presents() { ShopId = 1, PhoneId = 1, Amount = 7 });
            pres.Add(new Presents() { ShopId = 3, PhoneId = 4, Amount = 10 });

            //var newLst = phones.Where(p => p.Price > 10000).OrderByDescending(p => p.Model)
            //    .ThenByDescending(p => p.Price).Select(p => new { p.Brand, p.Model });

            //var lst2 = phones.SelectMany(p => p.Model.Split(' ')).Distinct();

            //Console.WriteLine(phones.Min(p => p.Model));

            //Console.WriteLine(newLst);
            //foreach (var p in lst2)
            //{
            //    Console.WriteLine(p);
            //}

            var grLst = phones.GroupBy(p => p.Brand).
               Select(g => new { Brand = g.Key, Count = g.Count(),
                   MaxPrice = g.Max(p => p.Price),
                   AvgId = g.Average(p => p.Id)
               }).Where(p=>p.MaxPrice<50000m);

            
            Console.WriteLine(" Группировка*********************** ");
            foreach(var b in grLst)
            {
                Console.WriteLine(b);
                
            }

            var result = pres.Join(shops,
                p => p.ShopId,
                s => s.Id,
                (p, s) => new { p.PhoneId, Shop = s.Address, p.Amount })
                .Join(phones,
                pr=>pr.PhoneId,
                ph=>ph.Id,
                (pr,ph)=>new {pr.Shop,pr.Amount,ph.Brand,ph.Model,ph.Price}
                );


            Console.WriteLine(" Соединение*********************** ");
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }




        }
    }
}









