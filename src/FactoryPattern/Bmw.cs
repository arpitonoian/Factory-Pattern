namespace FactoryPattern
{
    class Bmw : IProductCar
    {
        public string CarColor
        {
            get { return "Yellow"; }
        }

        public string GetCarModel
        {
            get { return "BMW X7"; }
        }
    }
}


