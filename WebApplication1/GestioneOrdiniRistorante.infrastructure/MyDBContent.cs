using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestioneOrdiniRistorante.Models;

namespace GestioneOrdiniRistorante.Infrastructure
{
    public class MyDBContent :  DbContext
    {
        public DbSet<Prodotto> Prodotto { get; set; }
        public DbSet<Utente> Utente { get; set; }  

        public MyDBContent()
        {

        }
        public MyDBContent(DbContextOptions<MyDBContent> config) : base(config)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=master;User Id=manager;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }


    }
}
