using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProject.Interfacies
{
    internal interface IEngine
    {
        public int OilCapacity { get; set; }

        public int CurrentOil { get; set; }

        public string FuelType { get; set; }

        public void RemainOilAmount();

        public void GoGasStation();
    }
}
