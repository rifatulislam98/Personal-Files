using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Factory.Example__01
{
    public class Car : IVehicle
    {
        public string GetVehicleName()
        {
            return "Toyota Harrier";
        }

        public string GetVehiclePrice()
        {
            return "75,00,000 BDT";
        }

        public string GetVehicleType()
        {
            return "Car";
        }
    }
}
