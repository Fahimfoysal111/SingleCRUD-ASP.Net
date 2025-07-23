using Microsoft.EntityFrameworkCore;
using ProjectCRUD.Models;

public class ApplicationDbContext : DbContext
{
    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt)
            : base(opt)
        {
        }

        public DbSet<Product> Products { get; set; }
    
}
