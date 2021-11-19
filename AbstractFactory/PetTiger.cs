using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PetTiger : ITiger
    {
        public void Aboutme()
        {
            Console.WriteLine("Pet Tiger : Toi thich mua lua");
        }
    }
}
