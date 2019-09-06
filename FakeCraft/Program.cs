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
            units.Add(new Zealot());

            for (int i = 0; i < units.Count; i++)
                units[i].Dead += Unit_Dead;

            for (int i = 0; i < units.Count; i++)
                TakeRandomDamage(units[i]);
        }

        private static void Unit_Dead(object sender, Unit.DeadEventArgs e)
        {
            Console.WriteLine($"{sender} has died with {e.RemainingDamage} damage(s)");
        }

        static void TakeRandomDamage(Unit unit)
        {
            int damage = _random.Next(50, 150);
            Console.Write($"[{damage}] ");

            unit.TakeDamage(damage);
            
            Console.WriteLine(unit.ToText());
        }
    }
}
