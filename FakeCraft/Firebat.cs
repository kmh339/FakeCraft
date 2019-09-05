namespace FakeCraft
{
    class Firebat
    {
        public Firebat()
        {
            HP = 60;
        }

        public int HP { get; set; }

        public string ToText()
        {
            return $"I am a firebat and I hava {HP} HP(s)";
        }
    }
}
