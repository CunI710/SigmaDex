using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities {
    public class SigmaEntity {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImageUrl  { get; set; }
        public required string AverageWeight { get; set; }
        public required string AverageHeight { get; set; }
        public int Testosterone { get; set; }
        public int EvolutionLevel { get; set; }
        public required List<SigmaTypeEntity> Types { get; set; }
        public List<SigmaTypeEntity>? Weaknesses { get; set; }
        public SigmaEntity? NextStep { get; set; }
        public SigmaEntity? PrevStep { get; set; }
        public List<SigmaEntity>? AllEvolution { get; set; }
    }
}
