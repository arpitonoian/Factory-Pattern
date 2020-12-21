namespace FactoryPattern
{
    class FactorySelection
    {
        public static CarModelFactory CreateCarFactory(string FactoryType)
        {
            if (FactoryType.ToLower() == "electric")
            {
                return new ElectricCarFactory();
            }
            else if (FactoryType.ToLower() == "mechanic")
            {
                return new MechanicCarFactory();
            }
            return null;
        }
    }
}
