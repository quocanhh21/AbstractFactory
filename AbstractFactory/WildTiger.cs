using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WildTiger : ITiger
    {
        public void Aboutme()
        {
            Console.WriteLine("Wild Tiger : Toi thich di san");
        }
    }
}
