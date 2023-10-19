using MeuSite.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuSite.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder mB)
        {
            mB.Entity<Produto>().HasKey(k => k.Id);
            mB.Entity<Produto>().Property(p => p.Nome).HasMaxLength(100).IsRequired();
            mB.Entity<Produto>().Property(p => p.Preco).HasPrecision(10, 2);
            mB.Entity<Produto>().Property(p => p.ImagemUrl).HasMaxLength(500);
            
        }
    }
}
