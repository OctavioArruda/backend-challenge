using Domain.Accounts;
using Domain.Transactions;

namespace Domain.Contracts.Interfaces.Services;

public interface ITransactionService
{
    public Task<Account> Process(Transaction transaction, long clientId);
}