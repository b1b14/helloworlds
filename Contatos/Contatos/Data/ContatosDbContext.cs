using Contatos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Contatos.Data
{
    public class ContatosDbContext : DbContext
    {
        public ContatosDbContext(DbContextOptions<ContatosDbContext> options) : base(options)
        {
        }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contato>().ToTable("Contato");
        }
    }
}

