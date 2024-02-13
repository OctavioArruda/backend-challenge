using Domain.Contracts.Interfaces;

namespace Application.Implementations.Services;

public sealed class AccountStatementService : IAccountStatementService
{
    public Task<BankAccountStatement> Get(long id)
    {
        throw new NotImplementedException();
    }
}