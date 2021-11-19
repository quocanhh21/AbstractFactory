using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Demo Astract Factory Pattern ***");
            IAnimalFactory animalFactory = FactoryProvider.GetAnimalFactory("wild");
            IDog dog = animalFactory.GetDog();
            dog.Aboutme();
            ITiger tiger = animalFactory.GetTiger();
            tiger.Aboutme();
            Console.WriteLine("**************");
            animalFactory = FactoryProvider.GetAnimalFactory("pet");
            dog = animalFactory.GetDog();
            dog.Aboutme();
            tiger = animalFactory.GetTiger();
            tiger.Aboutme();
            Console.WriteLine("**************");
        }
    }
}
