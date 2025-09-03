using Microsoft.EntityFrameworkCore.Storage;
using MySVFarmAssistantAPI.Domain.Common.Interfaces;

namespace MySVFarmAssistantAPI.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IDbContextTransaction _currentTransaction;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction != null)
                return; // Transaction déjà ouverte

            _currentTransaction = await _context.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task<int> CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction == null)
                throw new InvalidOperationException("Aucune transaction active");

            try
            {
                var result = await _context.SaveChangesAsync();
                await _currentTransaction.CommitAsync(cancellationToken);
                await DisposeTransactionAsync();
                return result;
            }
            catch
            {
                await RollbackTransactionAsync();
                throw;
            }
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.RollbackAsync(cancellationToken);
                await DisposeTransactionAsync();
            }
        }

        private async Task DisposeTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                await _currentTransaction.DisposeAsync();
                _currentTransaction = null;
            }
        }

        public void Dispose()
        {
            _currentTransaction?.Dispose();
            GC.SuppressFinalize(this);
        }
    }

}
