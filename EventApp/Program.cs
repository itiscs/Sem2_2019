using System;

namespace EventApp
{
    class Firedepartment
    {
        public void Work(string pname)
        {
            Console.WriteLine($"Пожарные едут в {pname}!!!");
        }

    }

    class Ambulance
    {
        public void Work(string pname)
        {
            Console.WriteLine($"Скорая едет в {pname}!!!");
        }

    }


    class Powerstation
    {
        public string Name { get; set; }

        public int CurrentTemp { get; set; }
        public int MaxTemp { get; set; }

        public event Action<string> Boom;

        public Powerstation(string name, int cur, int max)
        {
            Name = name;
            CurrentTemp = cur;
            MaxTemp = max;

        }
        public void TempUp()
        {
            CurrentTemp += 100;
            if (CurrentTemp > MaxTemp)
                Boom?.Invoke(Name);
        }

        public void TempDown()
        {
            CurrentTemp += 100;
        }

        public override string ToString()
        {
            return $"{Name} Current - {CurrentTemp}    Max - {MaxTemp}";
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Powerstation p1 = new Powerstation("Казань", 300, 1400);
            Powerstation p2 = new Powerstation("Чернобыль", 300, 1000);


            Firedepartment fd = new Firedepartment();
            Ambulance amb = new Ambulance();

            p1.Boom += fd.Work;
            p1.Boom += amb.Work;

            p2.Boom += fd.Work;
            p2.Boom += amb.Work;

            for (int i=0;i<10;i++)
            {
                p2.TempUp();
                p1.TempUp();
                Console.WriteLine(p1);
                Console.WriteLine(p2);
            }




        }
    }
}
