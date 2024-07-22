using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Query.Responses.Sigma {
    public class SigmaInfoResponse {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string AverageWeight { get; set; }
        public required string AverageHeight { get; set; }
        public int Testosterone { get; set; }
        public int EvolutionLevel { get; set; }
        public required List<string> Types { get; set; }
        public List<string>? Weaknesses { get; set; }
        public SigmaExampleResponse? NextStep { get; set; }
        public SigmaExampleResponse? PrevStep { get; set; }
    }
}
