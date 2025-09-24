using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_EFCore.AirlinesModels
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public char Gender { get; set; }
        public string? Position { get; set; }
        [MaxLength(4)]
        public string? BD_Year { get; set; }
        [MaxLength(2)]
        public string? BD_Month { get; set; }
        [MaxLength(2)]
        public string? BD_Day { get; set; }
        [ForeignKey(nameof(airline))]
        public int Al_Id { get; set; }
        public Airline airline { get; set; } = null!;
        public ICollection<Emp_Qualifications> emp_Qualifications { get; set; } = new HashSet<Emp_Qualifications>();
    }
}
