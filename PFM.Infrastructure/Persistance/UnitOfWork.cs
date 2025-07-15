using PFM.Domain.Interfaces;
using PFM.Infrastructure.Persistance.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFM.Infrastructure.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PFMDbContext _context;

        public UnitOfWork(PFMDbContext context)
        {
            _context = context;

        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}