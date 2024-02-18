using Domain.Contracts.Interfaces.Repositories;
using Domain.Contracts.Interfaces.Services;

namespace Application.Implementations.Services;

public sealed class AccountStatementService : IAccountStatementService
{
    private readonly IAccountStatementRepository _repository;

    public AccountStatementService(IAccountStatementRepository repository)
    {
        _repository = repository;
    }

    public async Task<BankAccountStatement> Get(long id)
    {
        return await _repository.Get(id);
    }
}