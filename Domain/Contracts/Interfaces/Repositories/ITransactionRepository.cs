using Domain.Accounts;
using Domain.Transactions;

namespace Domain.Contracts.Interfaces.Repositories;

public interface ITransactionRepository
{
    public Task<Account> Process(Transaction transaction);
}