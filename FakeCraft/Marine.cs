namespace FakeCraft
{
    class Marine : Unit
    {
        public Marine()
        {
            HP = 50;
        }

        public string ToText()
        {
            return $"I am a marine and I hava {HP} HP(s)";
        }
    }
}
