using System;

namespace FakeCraft
{
    public class Wraith : TerranUnit, ICloakable, IFlyable
    {
        public Wraith()
        {
            HP = 200;
        }

        public void Fly(int x, int y)
        {
            Console.WriteLine($"Flied to ({x},{y})");
        }

        public void Cloak()
        {
            Console.WriteLine("I am cloaked");
        }
    }
}
