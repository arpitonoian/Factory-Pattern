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
            var inputCar = Console.ReadLine();
            productCar = carModelFactory.GetCarInstance(inputCar);
            Console.WriteLine($"dzer avtomeqenai tesakn e |{carModelFactory.GetType().Name}|,avtomeqenai model| {productCar.GetCarModel}| guyne |{productCar.CarColor}|");
        }
    }
}

