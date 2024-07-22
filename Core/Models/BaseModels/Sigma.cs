using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.BaseModels
{
    public class Sigma
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl { get; set; }
        public required string AverageWeight { get; set; }
        public required string AverageHeight { get; set; }
        public int Testosterone { get; set; }
        public int EvolutionLevel { get; set; }
        public required List<SigmaType> Types { get; set; }
        public List<SigmaType>? Weaknesses { get; set; }
        public Sigma? NextStep { get; set; }
        public Sigma? PrevStep { get; set; }
    }
}
