namespace FakeCraft
{
    public class Marine : Unit
    {
        public Marine()
        {
            HP = 50;
        }

        public override string ToText()
        {
            return $"I am a marine and I hava {HP} HP(s)";
        }
    }
}
