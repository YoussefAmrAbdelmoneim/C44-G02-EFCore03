using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_EFCore.AirlinesModels
{
    [Owned]
    internal class Crew
    {
        public int Maj_Pilot { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string? Assistant { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string? Host1 { get; set; }
        [MaxLength(40)]
        [MinLength(3)]
        public string? Host2 { get; set; }
    }
}
