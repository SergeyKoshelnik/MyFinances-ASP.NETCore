using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFinances.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required] public string Username { get; set; }

        [Required] public string Password { get; set; }

        [Required] public string Question { get; set; }

        [Required] public string Answer { get; set; }

        public ICollection<Transaction> Transactions { get; set; }

        public ICollection<Debt> Debts { get; set; }

        public ICollection<Accumulation> Accumulations { get; set; }

    }
}