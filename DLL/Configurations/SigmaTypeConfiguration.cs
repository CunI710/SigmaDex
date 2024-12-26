using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class SigmaTypeConfiguration : IEntityTypeConfiguration<SigmaTypeEntity>
    {
        public void Configure(EntityTypeBuilder<SigmaTypeEntity> builder)
        {
            builder.HasIndex(st => st.Id);
        }
    }
}
