using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestioneOrdiniRistorante.Models;
using GestioneOrdiniRistorante.Models.Entities;
using Microsoft.Extensions.Configuration;

namespace GestioneOrdiniRistorante.Infrastructure
{
    public class MyDBContent :  DbContext
    {
        public DbSet<Prodotto> Prodotto { get; set; }
        public DbSet<Utente> Utente { get; set; }

        public DbSet<Ordine> Ordine { get; set; }

        public MyDBContent()
        {

        }
        public MyDBContent(DbContextOptions<MyDBContent> config) : base(config)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine("connessione in corso");
                var connectionString = "Server=localhost;Database=master;User Id=manager;Trusted_Connection=True;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString)
                              .LogTo(Console.WriteLine)
                              .EnableSensitiveDataLogging();
            Console.WriteLine("Connessione completata");
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Ordine>()
                .HasKey(o => o.Id);  // Impostazione esplicita della chiave primaria

            modelBuilder.Entity<Prodotto>()
                .Property(e => e.Prezzo);

            modelBuilder.Entity<Prodotto>()
                .HasKey(o => o.Id);  // Impostazione esplicita della chiave primaria

            modelBuilder.Entity<ProdottiInOrdine>()
                .HasKey(op => new { op.OrdineId, op.ProdottoId });

            modelBuilder.Entity<ProdottiInOrdine>()
                .HasOne(op => op.Ordine)
                .WithMany(o => o.OrdineProdotti)
                .HasForeignKey(op => op.OrdineId);

            modelBuilder.Entity<ProdottiInOrdine>()
                .HasOne(op => op.Prodotto)
                .WithMany() // Nessuna navigazione inversa
                .HasForeignKey(op => op.ProdottoId);
        }



    }
}
