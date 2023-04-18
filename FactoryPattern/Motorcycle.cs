using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {
        public string Color { get; set; }

        public bool hasHandBreak { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle");
        }
    }
}
