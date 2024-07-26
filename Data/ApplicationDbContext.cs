using akeassia2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace akeassia2.Data;
public class ApplicationDbContext:IdentityDbContext
{

public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
    base(options){

    }
    public DbSet<Taxon> Taxons{ get; set; }
    public DbSet<Wcvp> Wcvps{ get; set; }
}