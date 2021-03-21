using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBikesApi.Models
{
    public class Bike
    {
        int number { get; set; }
        string contractName { get; set; }
        string name { get; set; }
        string adress { get; set; }
        decimal latitude { get; set; }
        decimal longitude { get; set; }
        bool banking { get; set; }
        int AvailableBikes { get; set; }
        int AvailableStands { get; set; }
        int Capacity { get; set; }
        string status { get; set; }

    }
}
