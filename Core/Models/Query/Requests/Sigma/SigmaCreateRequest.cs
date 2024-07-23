using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Query.Requests.Sigma {
    public class SigmaCreateRequest {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        //public required string Image { get; set; }
        public required string AverageWeight { get; set; }
        public required string AverageHeight { get; set; }
        public int Testosterone { get; set; }
        public int EvolutionLevel { get; set; }
        public required List<int> TypeIds { get; set; }

        public List<int>? WeaknesseIds { get; set; }
        public int? NextStepId { get; set; }
        public int? PrevStepId { get; set; }
    }
}
