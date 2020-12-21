namespace FactoryPattern
{
    public abstract class CarModelFactory
    {
        public abstract IProductCar GetCarInstance(string CarType);
      
    }
}
