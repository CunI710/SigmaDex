using Core.Models.Query.Responses.Sigma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Query.Responses {
    public class SigmaTypeInfoResponse {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Desription { get; set; }
        public List<SigmaExampleResponse>? Sigmas { get; set; }
    }
}
