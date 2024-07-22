using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Query.Responses.Sigma
{
    public class SigmaExampleResponse {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string ImageUrl { get; set; }
        public required List<string> Types { get; set; }
    }
}
