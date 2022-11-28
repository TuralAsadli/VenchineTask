using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProject.Models
{
    internal abstract class Vehicle
    {
        int _driveeTime;
        int _drivePath;

        public int DriveTime { get => _driveeTime;
            set
            {
                if (value >= 0)
                {
                    _driveeTime = value;
                }
            }
        }

        public int DrivePath { get => _drivePath;
            set
            {
                if (value >= 0)
                {
                    _drivePath = value;
                }
            }
        }

        abstract public void AverageSpeed();
    }
}
