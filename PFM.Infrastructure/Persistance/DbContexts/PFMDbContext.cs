using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PFM.Domain.Entities;

namespace PFM.Infrastructure.Persistance.DbContexts
{
    public class PFMDbContext:DbContext
    {
        public PFMDbContext(DbContextOptions<PFMDbContext> options) : base(options) { }

        public DbSet<Transaction> Transactions => Set<Transaction>();

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => base.SaveChangesAsync(cancellationToken);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.BeneficiaryName).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
