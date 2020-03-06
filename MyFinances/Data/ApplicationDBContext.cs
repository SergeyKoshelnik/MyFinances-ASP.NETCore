using Microsoft.EntityFrameworkCore;
using MyFinances.Models;

namespace MyFinances.Data
{
    public class ApplicationDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = postgres; Password=1111;Server=localhost;Port=5432;Database=MyFinances; Integrated Security=true; Pooling=true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<Accumulation> Accumulations { get; set; }

    }
}
