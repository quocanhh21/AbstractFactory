using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class PetDog : IDog
    {
        public void Aboutme()
        {
            Console.WriteLine("Pet Dog : Toi thich an voi ngu");
        }
    }
}
