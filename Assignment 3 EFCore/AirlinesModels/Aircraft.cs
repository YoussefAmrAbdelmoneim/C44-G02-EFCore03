using Assignment_3_EFCore.AirlinesModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Aircraft
    {
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string? Model { get; set; }
        [ForeignKey(nameof(airline))]
        public int Al_Id { get; set; }
        public Airline airline { get; set; } = null!;
        public Crew crew { get; set; } = null!;
        public ICollection<Aircraft_Routes> aircraft_Routes { get; set; } = new HashSet<Aircraft_Routes>();
    }
}
