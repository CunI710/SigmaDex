using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.BaseModels
{
    public class SigmaType
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Desription { get; set; }
        public List<Sigma>? Sigmas { get; set; }
    }
}
