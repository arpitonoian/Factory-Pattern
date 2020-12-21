using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Nissan : IProductCar
    {
        public string CarColor
        {
            get { return "Blue"; }
        }

        public string GetCarModel
        {
            get { return "Nissan Leaf"; }
        }
    }
}
