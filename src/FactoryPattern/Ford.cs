namespace FactoryPattern
{
    class Ford : IProductCar
    {
        public string CarColor
        {
            get { return "Black"; }
        }

        public string GetCarModel
        {
            get { return "Ford Fiesta"; }
        }
    }
}