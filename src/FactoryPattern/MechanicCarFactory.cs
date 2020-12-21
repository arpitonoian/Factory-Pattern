
namespace FactoryPattern
{
    class MechanicCarFactory : CarModelFactory
    {
        public override IProductCar GetCarInstance(string CarType)
        {
            switch (CarType.ToLower())
            {
                case "hyundai":
                    return new Hyundai();
                case "bmw":
                    return new Bmw();
                case "ford":
                    return new Ford();
                default:
                    System.Environment.Exit(0);
                    return null;
            }
        }
    }
}