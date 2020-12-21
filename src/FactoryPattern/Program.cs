using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductCar productCar = null;
            CarModelFactory carModelFactory = null;
            Console.WriteLine("mutqagreq avtomeqenai type");
            var inputCarType = Console.ReadLine();
            carModelFactory = FactorySelection.CreateCarFactory(inputCarType);

            if (inputCarType.ToLower() == "electric")
                System.Console.WriteLine("entrel meqenaneric meke |Tesla,Nissan,Jaguar|");
            else if (inputCarType.ToLower() == "mechanic")
                System.Console.WriteLine("entrel meqenaneric meke |BMW,Ford,Hyundai|");
            var inputCar = Console.ReadLine();
            productCar = carModelFactory.GetCarInstance(inputCar);
            Console.WriteLine($"dzer avtomeqenai tesakn e |{productCar.Name}|,avtomeqenai model| {productCar.Model}| guyne |{productCar.Color}|");
        }
    }
}