using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using akeassia2.Models;

namespace akeassia2.Data.Interfaces
{
    public interface ITaxonService
    {
        Task<List<Taxon>> GetTaxonsAsync(int rankId);
    }
}