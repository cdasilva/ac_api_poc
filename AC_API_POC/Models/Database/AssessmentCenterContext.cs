using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentCenter.Models.Database
{
    public class AssessmentCenterContext : DbContext
    {
        public AssessmentCenterContext(DbContextOptions<AssessmentCenterContext> options) : base(options)
        {
        }

        public DbSet<FormData> Forms { get; set; }

        public DbSet<RegistrationData> Registrations { get; set; }

        public DbSet<LoincData> LoincCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FormData>().ToTable("Forms2");
            modelBuilder.Entity<RegistrationData>().ToTable("Registration");
            modelBuilder.Entity<LoincData>().ToTable("LOINC");
        }
    }
}
