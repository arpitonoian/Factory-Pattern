using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class FactorySelection
    {
        public static CarModelFactory CreateCarFactory(string FactoryType)
        {
            if (FactoryType.ToLower() == "electric")
            {
                System.Console.WriteLine("entrel meqenaneric meke |Tesla,Nissan,Jaguar|");
                return new ElectricCarFactory();
            }
            else if (FactoryType.ToLower() == "mechanic")
            {
                System.Console.WriteLine("entrel meqenaneric meke |BMW,Ford,Hyundai|");
                return new MechanicCarFactory();
            }
            else System.Environment.Exit(0);
            return null;
        }
    }
}
