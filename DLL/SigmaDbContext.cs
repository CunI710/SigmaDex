using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL {
    public class SigmaDbContext : DbContext{
        public DbSet<SigmaEntity> Sigmas { get; set; }
        public DbSet<SigmaTypeEntity> SigmaTypes { get; set; }
    }
}
