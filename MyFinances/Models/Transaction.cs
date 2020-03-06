using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyFinances.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateTimeTransaction { get; set; }

        [Required]public double Cost { get; set; }

        [Required]public double Income { get; set; }
        
        [Required]public string CommentforCategory { get; set; }

        public User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}
