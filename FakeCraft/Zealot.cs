using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCraft
{
    class Zealot : Unit
    {
        public Zealot()
        {
            HP = 100;
            Shield = 50;
        }

        public int Shield { get; set; }

        public override string ToText()
        {
            return $"I am a zealot and I hava {HP} HP(s) and I have {Shield} shield(s)";
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
