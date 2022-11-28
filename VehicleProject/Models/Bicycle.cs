using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleProject.Models
{
    internal class Bicycle : Vehicle
    {

        public string Pedalkind { get; set; }
        public override void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DrivePath);
        }
    }
}
