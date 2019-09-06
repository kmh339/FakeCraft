using System;

namespace FakeCraft
{
    public class Carrier : ProtossUnit, IFlyable
    {
        public Carrier()
        {
            HP = 400;
            Shield = 300;
        }

        public void Fly(int x, int y)
        {
            Console.WriteLine($"Flied Intercepters to ({x},{y})");
        }
    }
}
