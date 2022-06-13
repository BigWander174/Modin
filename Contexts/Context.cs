using Microsoft.EntityFrameworkCore;
using Modin.Model;

namespace Modin.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineInPharmacy> MedicinesInFarmacies { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Modin;Username=postgres;Password=BigGuardian");
        }
    }
}
