using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akeassia2.Models
{
    public class PlantPart
    {
        public int PlantPartId { get; set; }
        public int PlantPartsName { get;set;}
        public int ParentID { get;set;}
        public PlantPart Parent { get; set;}    
    }
}