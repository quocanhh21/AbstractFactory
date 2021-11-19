using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class WildDog : IDog
    {
        public void Aboutme()
        {
            Console.WriteLine("Wild Dog : Toi thich dẫy");
        }
    }
}
