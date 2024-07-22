using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Query.Requests.Sigmatype {
    public class SigmaTypeCreateRequest {
        public required string Name { get; set; }
        public required string Desription { get; set; }
    }
}
