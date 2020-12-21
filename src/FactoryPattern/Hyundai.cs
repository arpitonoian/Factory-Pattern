namespace FactoryPattern
{
    class Hyundai : IProductCar
    {
        public string CarColor
        {
            get { return "White"; }
        }

        public string GetCarModel
        {
            get { return "HYUNDAI i30"; }
        }
    }
}

