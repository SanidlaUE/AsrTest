using AsrTest.CashRegister;
using Microsoft.EntityFrameworkCore;

namespace AsrTest.DataBase
{
    internal class AppDbContext : DbContext
    {
        public DbSet<CashReceipt> CashReceipt { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("");
        }
    }
}
