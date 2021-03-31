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
        [RegularExpression(@"^[a-zA-Z''-'\s]{2,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string ContractName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{2,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9''-'\s]{1,200}$",
         ErrorMessage = "Characters are not allowed.")]
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
        [RegularExpression("OPEN|CLOSE")]
        public string Status { get; set; }

    }
}
