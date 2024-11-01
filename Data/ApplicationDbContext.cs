using Microsoft.EntityFrameworkCore;

namespace PescaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<PescaAPI.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<PescaAPI.Models.Fornecedor> Fornecedor { get; set; } = default!;
        public DbSet<PescaAPI.Models.Venda> Venda { get; set; } = default!;
        public DbSet<PescaAPI.Models.Produto> Produto { get; set; } = default!;
    }
}
