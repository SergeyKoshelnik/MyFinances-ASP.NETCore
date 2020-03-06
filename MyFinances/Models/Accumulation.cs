using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinances.Models
{
    public class Accumulation
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateTimeAccumulation { get; set; }

        [Required] public string AccumulationName { get; set; }

        [Required] public double SummofAccumulation { get; set; }

        public double Contributed { get; set; }

        public double Accumulated { get; set; }

        public string CommentforAccumulation { get; set; }

        public User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
