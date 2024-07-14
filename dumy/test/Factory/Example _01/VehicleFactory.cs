using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Factory.Example__01
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            if (type == "Car")
            {
                return new Car();
            }
            else if(type == "Bus")
            {
                return new Bus();
            }
            else if (type == "Truck")
            {
                return new Truck();
            }

            return null;
        }
    }
}
