using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkProject.Data
{
    public class Transmission
    {
        public TransmissionType TransmissionType { get; set; }
        public byte GearsNumber { get; set; }
        public string? TransmissionManufacturer { get; set; } // Getrag, Hughes, LuK  
    }
}
