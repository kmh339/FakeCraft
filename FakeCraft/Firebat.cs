namespace FakeCraft
{
    class Firebat : Unit
    {
        public Firebat()
        {
            HP = 60;
        }

        public override string ToText()
        {
            return $"I am a firebat and I hava {HP} HP(s)";
        }
    }
}
