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
    [PrimaryKey(nameof(Emp_Id),nameof(Qualifications))]
    internal class Emp_Qualifications
    {
        [ForeignKey(nameof(employee))]
        public int Emp_Id { get; set; }
        public string? Qualifications { get; set; }
        public Employee employee { get; set; } = null!;
    }
}
