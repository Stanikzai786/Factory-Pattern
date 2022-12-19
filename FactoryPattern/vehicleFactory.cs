using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class vehicleFactory
    {
        public IVehicle CreatVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color= "Blue", IsDriveable = true};

                case "Moto":
                    return new MOTO();
                default:
                    return new Car();
            }
        }
    }
}
