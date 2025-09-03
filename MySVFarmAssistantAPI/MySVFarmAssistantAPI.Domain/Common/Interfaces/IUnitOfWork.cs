namespace MySVFarmAssistantAPI.Domain.Common.Interfaces;

public interface IUnitOfWork
{
    Task BeginTransactionAsync(CancellationToken cancellationToken);
    Task<int> CommitTransactionAsync(CancellationToken cancellationToken);
    Task RollbackTransactionAsync(CancellationToken cancellationToken);
}
