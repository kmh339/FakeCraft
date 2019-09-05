using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCraft
{
    class Program
    {
        static Random _random = new Random();
            
        static void Main(string[] args)
        {
            Marine m1 = new Marine();
            Firebat f1 = new Firebat();

            TakeRandomDamageForMarine(m1);
            TakeRandomDamageForFirebat(f1);
        }

        static void TakeRandomDamageForMarine(Marine marine)
        {
            int damage = _random.Next(1, 6);

            while (damage > 0)
            {
                damage--;
                marine.HP--;
            }

            Console.WriteLine(marine.ToText());
        }

        static void TakeRandomDamageForFirebat(Firebat firebat)
        {
            int damage = _random.Next(1, 6);

            while (damage > 0)
            {
                damage--;
                firebat.HP--;
            }

            Console.WriteLine(firebat.ToText());
        }
    }
}
