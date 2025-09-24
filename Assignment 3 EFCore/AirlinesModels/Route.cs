using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Route
    {
        [Key]
        public int Id { get; set; }
        public string? Distance { get; set; }
        public string? Destination { get; set; }
        public char Origin { get; set; }
        public string? Classification { get; set; }
        public ICollection<Aircraft_Routes> aircraft_Routes { get; set; } = new HashSet<Aircraft_Routes>();
    }
}
