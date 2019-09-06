using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCraft
{
    public abstract class ProtossUnit : Unit
    {
        public int Shield { get; set; }

        public override string ToText()
        {
            return base.ToText() + $" and I have {Shield} shield(s)";
        }

        public override void TakeDamage(int damage)
        {
            while (damage > 0)
            {
                if (Shield == 0)
                    break;

                damage--;
                Shield--;
            }

            base.TakeDamage(damage);
        }
    }
}
