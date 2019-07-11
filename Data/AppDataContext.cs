using Microsoft.EntityFrameworkCore;

namespace CoreWebAPI_EFCore_Swagger.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext (DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<CoreWebAPI_EFCore_Swagger.Models.Category> Category { get; set; }

        public DbSet<CoreWebAPI_EFCore_Swagger.Models.Product> Product { get; set; }
    }
}
