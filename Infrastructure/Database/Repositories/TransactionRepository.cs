using Domain.Accounts;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Transactions;

namespace Infrastructure.Database.Repositories;

public sealed class TransactionRepository : ITransactionRepository
{
    public Task<Account> Process(Transaction transaction)
    {
        throw new NotImplementedException();
    }
}