﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public string Color { get; set; }
        public bool isDriveable { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Sorry, can't text I am driving my {Color} car!");
        }

    }
}
