using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
