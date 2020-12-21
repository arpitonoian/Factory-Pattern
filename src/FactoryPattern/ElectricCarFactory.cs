namespace FactoryPattern
{
    class ElectricCarFactory : CarModelFactory
    {
        public override IProductCar GetCarInstance(string CarType)
        {
            switch(CarType.ToLower())
            {
                case "nissan":
                       return new Nissan();
                case "tesla":
                    return new Tesla();
                case " jaguar":
                    return new Jaguar();
                default:
                    System.Environment.Exit(0);
                    return null;
            }
        }
    }
}

