using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using akeassia2.Data.Interfaces;
using akeassia2.Models;
using Microsoft.EntityFrameworkCore;

namespace akeassia2.Data.Services
{
    public class Taxonservice:ITaxonService
    {
        ApplicationDbContext _context;
        public Taxonservice(ApplicationDbContext context){
            _context = context;
        }

        public async Task<List<Taxon>> GetTaxonsAsync(int rankId){
            return await _context.Taxons.Where(a=>a.RankId==rankId).OrderBy(a=>a.scientificName).ToListAsync();
        }
    }
}