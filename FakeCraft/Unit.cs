namespace FakeCraft
{
    abstract class Unit
    {
        public int HP { get; set; }

        public abstract string ToText();

        public virtual void TakeDamage(int damage)
        {
            while (damage > 0)
            {
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
