namespace FakeCraft
{
    abstract class Unit
    {
        public int HP { get; set; }

        public abstract string ToText();
    }
}
