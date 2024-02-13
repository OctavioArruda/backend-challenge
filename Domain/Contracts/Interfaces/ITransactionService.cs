using Domain.Accounts;
using Domain.Transactions;

namespace Domain.Contracts.Interfaces;

public interface ITransactionService
{
    public Task<Account> Process(Transaction transaction);
}