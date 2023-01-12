namespace WCLManagement.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        Task<int> CommitAsync();
    }
}
