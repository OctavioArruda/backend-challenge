namespace Domain.Contracts.Interfaces.Services;

public interface IAccountStatementService
{
    public BankAccountStatement Get(long id);
}