namespace Domain.Contracts.Interfaces;

public interface IAccountStatementService
{
    public Task<BankAccountStatement> Get(long id);
}