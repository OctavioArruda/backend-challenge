namespace Domain.Contracts.Interfaces.Repositories;

public interface IAccountStatementRepository
{
    public Task<BankAccountStatement> Get(long id);
}