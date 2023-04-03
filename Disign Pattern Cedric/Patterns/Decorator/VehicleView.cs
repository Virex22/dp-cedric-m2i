﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    public class VehicleView : IVehicleGraphicComponent
    {
        public void Show()
        {
            Console.WriteLine("Voiture");
        }
    }
}