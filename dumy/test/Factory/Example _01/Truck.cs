using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Factory.Example__01
{
    public class Truck : IVehicle
    {
        public string GetVehicleName()
        {
            return "Toyota Revo";
        }

        public string GetVehiclePrice()
        {
            return "45,00,000 BDT";
        }

        public string GetVehicleType()
        {
            return "Truck";
        }
    }
}
