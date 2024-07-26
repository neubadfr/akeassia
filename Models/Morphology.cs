using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akeassia2.Models
{
    public class Description
    {
        public int DescriptionId { get; set; }
        public int PlantPartId { get; set; }
        public PlantPart PlantPart{ get; set; }
        public double Length{ get; set; }
        public double Width{ get; set; }
        public int number{ get; set; }
        public double diameter{ get; set; }
        public string aspect{ get; set; }
        public string shape{ get; set; }
        public string color{ get; set; }
        public string position{ get; set; }
    }
}