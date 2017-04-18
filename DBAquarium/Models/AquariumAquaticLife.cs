using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAquarium.Models
{
    class AquariumAquaticLife
    {
        public int Id { get; set; }

        public int? OceansId { get; set; }
        public int? Aquariums { get; set; }
        public int? AquaticLife { get; set; }

        public Oceans Oceans { get; set; }
        public Aquariums Tank { get; set; }
        public AquaticLife Fishes { get; set; }
    }
}
