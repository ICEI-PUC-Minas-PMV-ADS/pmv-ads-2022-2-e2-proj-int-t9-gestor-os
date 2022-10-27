
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestorOS.Models
{
    public class BancodeDados : DbContext
    {
        public DbSet<OrdensDeServicos> OrdensDeServicos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=GestorOS;Integrated Security=True");
        }
    }
}
