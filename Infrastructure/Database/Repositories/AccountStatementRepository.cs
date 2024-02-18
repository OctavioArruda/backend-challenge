using Domain.Contracts.Interfaces.Repositories;

namespace Infrastructure.Database.Repositories;

public sealed class AccountStatementRepository : IAccountStatementRepository
{
    public Task<BankAccountStatement> Get(long id)
    {
        throw new NotImplementedException();
    }
}