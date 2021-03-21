using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBikesApi.Models
{
    public class Bike
    {
        public int Number { get; set; }
        public string NontractName { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public bool Banking { get; set; }
        public int AvailableBikes { get; set; }
        public int AvailableStands { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }

    }
}
