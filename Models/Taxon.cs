using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akeassia2.Models
{
    public class Taxon
    {
        public string TaxonId { get; set; }
        public string scientificName { get;set; }
        public int RankId { get; set; }
        public Rank Rank { get; set; }  
    }
}