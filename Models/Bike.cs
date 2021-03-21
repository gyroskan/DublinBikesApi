using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBikesApi.Models
{
    public class Bike
    {
        [Key]
        public int Number { get; set; }
        [Required]
        public string ContractName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public decimal Latitude { get; set; }
        [Required]
        public decimal Longitude { get; set; }
        [Required]
        public bool Banking { get; set; }
        [Required]
        public int AvailableBikes { get; set; }
        [Required]
        public int AvailableStands { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string Status { get; set; }

    }
}
