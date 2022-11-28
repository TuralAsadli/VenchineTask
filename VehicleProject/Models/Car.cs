using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleProject.Interfacies;

namespace VehicleProject.Models
{
    internal class Car : Vehicle ,IEngine
    {
        byte _doorCount;
        int _oilCapacity;
        int _currentOil;
        string _fuelType;

        public byte DoorCount { get => _doorCount;
            set
            {
                if (value >= 0)
                {
                    _doorCount = value;
                }
            }
        }
        public int OilCapacity
        {
            get => _oilCapacity;
            set
            {
                if (value >= 0)
                {
                    _oilCapacity = value;
                }
            }
        }
        public int CurrentOil
        {
            get => _currentOil;
            set
            {
                if (value >= 0)
                {
                    _currentOil = value;
                }
            }
        }
        public string FuelType
        {
            get => _fuelType;
            set
            {
                if (value.Length >= 0)
                {
                    _fuelType = value;
                }
            }
        }

        public Car(byte door, int oilcap, int currentoil, string fueltype)
        {
            this.DoorCount = door;
            this.OilCapacity = oilcap;
            
        }

        public override void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DrivePath);
        }

        public void GoGasStation()
        {
            var neededOil = OilCapacity - CurrentOil;
            _currentOil += neededOil;
        }

        public void RemainOilAmount()
        {
            Console.WriteLine(OilCapacity - CurrentOil);
        }
    }
}
