using AsrTest.CashRegister;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
