using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace akeassia2.Models
{
    [Table("wcvp_names")]
    public class Wcvp
    {

        [Key]
        public string plant_name_id{ get; set; }
        public string ipni_id{ get; set;}
        public string taxon_rank{ get; set; }
        public string taxon_status{ get; set; }
        public string family{ get; set; }
        public string genus_hybrid{ get; set; }
        public string genus{ get; set; }

        public string species_hybrid{ get; set; }   
        public string species{ get; set; }
        public string infraspecific_rank{ get; set; }
        public string  infraspecies{ get; set; }
        public string parenthetical_author{ get; set; }
        public string primary_author{ get; set; }
        public string publication_author{ get; set; }
        public string place_of_publication{ get; set; }
        public string volume_and_page{ get; set; }
        public string first_published{ get; set; }
        public string  nomenclatural_remarks{get;set;}
        public string geographic_area{ get; set; }
        public string lifeform_description{ get; set; }
        public string climate_description{ get; set; }
        public string taxon_name{ get; set; }
        public string taxon_authors{ get; set; }
        public string accepted_plant_name_id{ get; set; }
        public string basionym_plant_name_id{get; set; }
        public string replaced_synonym_author{ get; set; }
        public string homotypic_synonym{ get; set; }
        public string parent_plant_name_id { get; set; }
        public string powo_id{ get; set; }
        public string hybrid_formula{ get; set; }
        public string reviewed{ get; set; }






    }
}