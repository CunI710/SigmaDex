using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class SigmaDbContext : DbContext{
        public DbSet<SigmaEntity> Sigmas { get; set; }
        public DbSet<SigmaTypeEntity> SigmaTypes { get; set; }
        public SigmaDbContext(DbContextOptions<SigmaDbContext> options):base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // Настройка отношения один-ко-многим
            modelBuilder.Entity<SigmaEntity>()
                .HasMany(s => s.Types)
                .WithMany(t => t.SigmaTypes);
            modelBuilder.Entity<SigmaEntity>()
                .HasMany(s => s.Weaknesses)
                .WithMany(t => t.SigmaWeaknesses);
            modelBuilder.Entity<SigmaEntity>()
                .HasOne(s => s.PrevStep)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<SigmaEntity>()
                .HasOne(s => s.NextStep)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<SigmaEntity>()
                .HasMany(s => s.AllEvolution)
                .WithMany();
        }

    }
}
