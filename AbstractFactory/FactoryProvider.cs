﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class FactoryProvider
    {
        public static IAnimalFactory GetAnimalFactory(string factoryType)
        {
            if (factoryType.Contains("wild"))
            {
                return new WildAnimalFactory();
            }
            else if (factoryType.Contains("pet"))
            {
                return new PetAnimalFactory();
            }
            else
            {
                throw new ArgumentException("Ban can dien wild hoac pet");
            }

        }
    }
}
