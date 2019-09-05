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
    }
}
