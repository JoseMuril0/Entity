using Microsoft.EntityFrameworkCore;
using System;

namespace AluraPraticandoBD
{
    internal class LojaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Cormcial;Trusted_Connection=true;");
        }
    }
}