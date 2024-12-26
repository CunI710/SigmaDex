using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class SigmaConfigurations : IEntityTypeConfiguration<SigmaEntity>
    {
        public void Configure(EntityTypeBuilder<SigmaEntity> builder)
        {
            builder.HasIndex(s => s.Id);
            builder
                .HasMany(s => s.Types)
                .WithMany(t => t.SigmaTypes);
            builder
                .HasMany(s => s.Weaknesses)
                .WithMany(t => t.SigmaWeaknesses);
            builder
                .HasOne(s => s.PrevStep)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasOne(s => s.NextStep)
                .WithOne()
                .OnDelete(DeleteBehavior.SetNull);
            builder
                .HasMany(s => s.AllEvolution)
                .WithMany();
        }
    }
}
