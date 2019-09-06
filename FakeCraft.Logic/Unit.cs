using System;

namespace FakeCraft
{
    public abstract class Unit
    {
        public int HP { get; set; }

        public Action<int> OnDead;

        public abstract string ToText();

        public virtual void TakeDamage(int damage)
        {
            while (damage > 0)
            {
                if (HP == 0)
                {
                    OnDead(damage);
                    break;
                }

                damage--;
                HP--;
            }
        }

        public void TakeMultipleDamages(params int[] damages)
        {
            for (int i = 0; i < damages.Length; i++)
                TakeDamage(damages[i]);
        }
    }
}
