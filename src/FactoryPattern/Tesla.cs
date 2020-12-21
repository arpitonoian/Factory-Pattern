namespace FactoryPattern
{
    class Tesla : IProductCar
    {
        public string CarColor
        {
            get { return "Red"; }
        }

        public string GetCarModel
        {
            get { return "Tesla Model 3"; }
        }

    }
}
