using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Factory.Example__01
{
    public class Bus : IVehicle
    {
        public string GetVehicleName()
        {
            return "Hino AK 1J";
        }

        public string GetVehiclePrice()
        {
            return "85,00,000 BDT";
        }

        public string GetVehicleType()
        {
            return "Bus";
        }
    }
}
