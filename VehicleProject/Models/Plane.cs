using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProject.Interfacies;

namespace VehicleProject.Models
{
    internal class Plane : Vehicle , IEngine
    {
        int _wingLength;
        public int WingLength { get => _wingLength;
            set
            {
                if (value >= 0)
                {
                    _wingLength = value;
                }
            }
        }

        public int OilCapacity { get; set; }
        public int CurrentOil { get; set; }
        public string FuelType { get;set; }

        public override void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DrivePath);
        }

        public void RemainOilAmount()
        {
            Console.WriteLine(OilCapacity - CurrentOil);
        }

        public void GoGasStation()
        {
            var neededOil = OilCapacity - CurrentOil;
            CurrentOil += neededOil;
        }
    }
}
