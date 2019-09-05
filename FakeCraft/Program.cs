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
            List<Unit> units = new List<Unit>();
            units.Add(new Marine());
            units.Add(new Marine());
            units.Add(new Firebat());

            for (int i = 0; i < units.Count; i++)
                TakeRandomDamage(units[i]);
        }

        static void TakeRandomDamage(Unit unit)
        {
            int damage = _random.Next(1, 6);

            while (damage > 0)
            {
                damage--;
                unit.HP--;
            }

            Console.WriteLine(unit.ToText());
        }
    }
}
