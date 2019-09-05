namespace FakeCraft
{
    class Firebat : Unit
    {
        public Firebat()
        {
            HP = 60;
        }

        public string ToText()
        {
            return $"I am a firebat and I hava {HP} HP(s)";
        }
    }
}
