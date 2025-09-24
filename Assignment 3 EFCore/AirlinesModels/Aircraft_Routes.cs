using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    [PrimaryKey(nameof(AC_Id),nameof(Route_Id),nameof(Departure))]
    internal class Aircraft_Routes
    {
       [ForeignKey(nameof(aircraft))]
        public int AC_Id { get; set; }
        [ForeignKey(nameof(routes))]
        public int Route_Id { get; set; }
        public DateTime Departure { get; set; }
        public int Num_Of_Pass { get; set; }
        public decimal Price { get; set; }
        public DateTime Arrival { get; set; }
        public Aircraft aircraft { get; set; } = null!;
        public Route routes { get; set; } = null!;
    }
}
