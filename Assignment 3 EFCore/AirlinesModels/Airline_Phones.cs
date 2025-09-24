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
    [PrimaryKey(nameof(Al_Id),nameof(Phones))]
    internal class Airline_Phones
    {
        [ForeignKey(nameof(airline))]
        public int Al_Id { get; set; }
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public int Phones { get; set; }
        public Airline airline { get; set; } = null!;
    }
}
