using DataAccess.Configurations;
using DataAccess.Entities;
using DataAccess.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SigmaDbContext(
        IOptions<AuthorizationOptions> authOptions,
        DbContextOptions<SigmaDbContext> options) : DbContext(options)
    {
        public DbSet<SigmaEntity> Sigmas { get; set; } = null!;
        public DbSet<SigmaTypeEntity> SigmaTypes { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; } = null!;
        public DbSet<RoleEntity> Roles { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SigmaDbContext).Assembly);
            modelBuilder.ApplyConfiguration(new RolePermissionConfiguration(authOptions.Value));

            // Настройка отношения один-ко-многим
        }

    }
}
