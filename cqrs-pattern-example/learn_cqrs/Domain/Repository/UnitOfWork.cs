using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace learn_cqrs.Domain.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task SaveChangeAsync(CancellationToken cancel)
        {
            await _context.SaveChangesAsync(cancel);
        }
    }
}
