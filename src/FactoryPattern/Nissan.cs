﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Nissan : IProductCar
    {
        public string Color
        {
            get { return "Blue"; }
        }

        public string Model
        {
            get { return "Nissan Leaf"; }
        }

        public string Name
        {
            get { return "Mechanic"; }
        }
    }
}
