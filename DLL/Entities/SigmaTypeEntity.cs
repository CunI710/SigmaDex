using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities {
    public class SigmaTypeEntity {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Desription { get; set; }
        public List<SigmaEntity>? Sigmas { get; set; }
    }
}
