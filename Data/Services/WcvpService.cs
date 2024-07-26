using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using akeassia2.Data.Interfaces;
using akeassia2.Models;
using Microsoft.EntityFrameworkCore;

namespace akeassia2.Data.Services
{
    public class WcvpService:IWcvpService
    {
        ApplicationDbContext _context;
        public WcvpService(ApplicationDbContext context){
            _context = context;
        }

        public async Task<List<Wcvp>> GetWcvpsAsync(string genus, string family){
            List<Wcvp> wcvps = await _context.Wcvps.ToListAsync();
            if(string.IsNullOrEmpty(genus)&&string.IsNullOrEmpty(family)){
                return wcvps;
            }
            if(!string.IsNullOrEmpty(genus)){
                wcvps=wcvps.Where(w => w.genus == genus).ToList();
            }
            if(!string.IsNullOrEmpty(family)){
                wcvps=wcvps.Where(w => w.family == family).ToList();
            }
            return wcvps;

        }
    }
    
}