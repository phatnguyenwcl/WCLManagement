using WCLManagement.EF;
using WCLManagement.Infrastructure.Interfaces;

namespace WCLManagement.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly WCLManagementDbContext _context;

        public UnitOfWork(WCLManagementDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public Task<int> CommitAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
