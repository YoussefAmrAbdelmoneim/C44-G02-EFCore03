using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(nameof(airlines))]
        public int Al_Id { get; set; }
        public Airline airlines { get; set; } = null!;
    }
}
