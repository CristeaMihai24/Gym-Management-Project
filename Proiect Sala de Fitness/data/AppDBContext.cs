using System;
using Microsoft.EntityFrameworkCore;
using Proiect_Sala_de_Fitness.dataModels;

namespace Proiect_Sala_de_Fitness
{
    public class AppDbContext : DbContext
    {
        public DbSet<Membru> Membri { get; set; }
        public DbSet<Abonament> Abonamente { get; set; }
        public DbSet<Antrenor> Antrenori { get; set; }
        public DbSet<Rezervari> Rezervari { get; set; }
        public DbSet<LogSala> LogSala { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBFitness;Trusted_Connection=True;");
            }
        }
    }
}