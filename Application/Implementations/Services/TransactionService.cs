using Domain.Accounts;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;
using Domain.Transactions;

namespace Application.Implementations.Services;

public sealed class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _repository;

    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }

    public async Task<Account> Process(Transaction transaction)
    {
        return await _repository.Process(transaction);
    }
}