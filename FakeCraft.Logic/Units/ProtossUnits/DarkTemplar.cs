using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeCraft
{
    public class DarkTemplar : ProtossUnit, ICloakable
    {
        public DarkTemplar()
        {
            HP = 100;
            Shield = 100;
        }

        public void Cloak()
        {
            Console.WriteLine("I am always invible");
        }
    }
}
