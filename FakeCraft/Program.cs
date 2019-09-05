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
            // 부모 자리에 자식을 대입 할 수 있음

            Unit m1 = new Marine();
            Unit f1 = new Firebat();

            TakeRandomDamage(m1);
            TakeRandomDamage(f1);
        }

        static void TakeRandomDamage(Unit unit)
        {
            int damage = _random.Next(1, 6);

            while (damage > 0)
            {
                damage--;
                unit.HP--;
            }

            //Console.WriteLine(marine.ToText());
        }
    }
}
