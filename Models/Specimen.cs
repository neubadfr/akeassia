using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akeassia2.Models
{
    public class Specimen
    {
        public int SpecimenId { get; set; }
        public string collector { get; set;}
        public string country{ get; set;}
        public string locality{ get; set;}
        public string number{ get; set;}
        public string WcvpID{ get; set; }
        public Wcvp Wcvp{ get; set; }
        public int? NomenclaturalTypeID{ get; set;}
        public NomenclaturalType NomenclaturalType{ get; set;}

    }
}