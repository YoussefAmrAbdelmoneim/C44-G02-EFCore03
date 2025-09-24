using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Airline
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Cont_Person { get; set; }
        public ICollection<Employee> employee { get; set; } = new HashSet<Employee>();
        public ICollection<Transaction> transaction { get; set; } = new HashSet<Transaction>();
        public ICollection<Aircraft> aircraft { get; set; } = new HashSet<Aircraft>();
        public ICollection<Airline_Phones> airline_Phones { get; set; } = new HashSet<Airline_Phones>();
    }
}
