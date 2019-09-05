namespace FakeCraft
{
    class Marine
    {
        public Marine()
        {
            HP = 50;
        }

        public int HP { get; set; }

        public string ToText()
        {
            return $"I am a marine and I hava {HP} HP(s)";
        }
    }
}
