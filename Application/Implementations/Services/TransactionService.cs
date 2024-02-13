using Domain.Accounts;
using Domain.Contracts.Interfaces;
using Domain.Transactions;

namespace Application.Implementations.Services;

public sealed class TransactionService : ITransactionService
{
    public Task<Account> Process(Transaction transaction)
    {
        throw new NotImplementedException();
    }
}