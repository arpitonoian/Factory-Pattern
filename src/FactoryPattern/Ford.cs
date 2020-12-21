namespace FactoryPattern
{
    class Ford : IProductCar
    {
        public string Color
        {
            get { return "Black"; }
        }

        public string Model
        {
            get { return "Ford Fiesta"; }
        }

        public string Name
        {
            get { return "Mechanic"; }
        }
    }
}