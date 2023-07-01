using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data
{
    public class Chassis
    {
        public byte WheelsNumber { get; set; }
        public string? VIN { get; set; }
        public ushort PermissibleLoad { get; set; }
    }
}
