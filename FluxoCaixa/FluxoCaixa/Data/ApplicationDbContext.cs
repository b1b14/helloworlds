using FluxoCaixa.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FluxoCaixa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContaFinanceira> ContasFinanceiras { get; set; }
        public DbSet<FluxoCaixa.Models.Conta> Conta { get; set; } = default!;
        public DbSet<FluxoCaixa.Models.FluxoConta> FluxoConta { get; set; } = default!;
    }
}
