
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GestorOS.Models
{
    public class BancodeDados : DbContext 
    {
        public BancodeDados(DbContextOptions<BancodeDados> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<OrdensDeServicos> OrdensDeServicos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    
        public DbSet<UsuarioModel> Usuario { get; set; }
    

    }
}
