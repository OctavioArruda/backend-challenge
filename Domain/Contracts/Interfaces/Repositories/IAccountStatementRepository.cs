namespace Domain.Contracts.Interfaces.Repositories;

public interface IAccountStatementRepository
{
    public BankAccountStatement Get(long id);
}