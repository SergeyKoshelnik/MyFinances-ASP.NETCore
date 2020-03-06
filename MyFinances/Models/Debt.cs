using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinances.Models
{
    public class Debt
    {
        public int Id { get; set; }

        [Required] public string DebtName { get; set; }

        [Required] public double SummofDebt { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEndDate { get; set; }

        public User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        

    }
}
