using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models;

public class PjatkDbContext: DbContext {
    
    
    public DbSet<Animal> Animals { get; set; }
}