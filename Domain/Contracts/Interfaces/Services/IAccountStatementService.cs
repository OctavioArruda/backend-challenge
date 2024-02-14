namespace Domain.Contracts.Interfaces.Services;

public interface IAccountStatementService
{
    public Task<BankAccountStatement> Get(long id);
}