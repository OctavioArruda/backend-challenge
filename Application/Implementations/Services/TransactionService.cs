using Domain.Accounts;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;
using Domain.Transactions;

namespace Application.Implementations.Services;

public sealed class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _repository;
    private readonly IAccountStatementService _balanceService;

    public TransactionService(ITransactionRepository repository,
        IAccountStatementService balanceService)
    {
        _repository = repository;
        _balanceService = balanceService;
    }

    public async Task<Account> Process(Transaction transaction, long clientId)
    {
        var accountState = _balanceService.Get(clientId);
        if (transaction.Tipo == "d")
        {
            var currentBalance = accountState.Balance.Total;
            var newBalance = currentBalance -= transaction.Valor;

            // Method to update clientes table with new balance
        }
        return await _repository.Process(transaction, clientId);
    }
}