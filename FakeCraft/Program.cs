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
            units.Add(new Firebat());
            units.Add(new Zealot());
            units.Add(new DarkTemplar());
            units.Add(new Wraith());
            units.Add(new Carrier());

            foreach (Unit unit in units)
                unit.Dead += Unit_Dead;

            foreach (Unit unit in units)
                TakeRandomDamage(unit);


            foreach (Unit unit in units)
            {
                if (unit is IFlyable)
                    FlyBy((IFlyable)unit, 1, 2, 3, 4);
                if (unit is ICloakable)
                    Cloak((ICloakable)unit);
            }
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

        static void FlyBy(IFlyable unit, int x1, int y1, int x2, int y2)
        {
            // duck typing
            unit.Fly(x1, y1);
            unit.Fly(x2, y2);
        }

        static void Cloak(ICloakable unit)
        {
            unit.Cloak();
        }
    }
}
