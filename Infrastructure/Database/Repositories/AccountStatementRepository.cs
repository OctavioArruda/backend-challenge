using Domain.Accounts;
using Domain.Contracts.Interfaces.Repositories;
using Infrastructure.Database.ApplicationContext;

namespace Infrastructure.Database.Repositories;

public sealed class AccountStatementRepository : IAccountStatementRepository
{
    private readonly ApplicationDbContext _context;

    public AccountStatementRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public BankAccountStatement Get(long id)
    {
        var balance = _context.Accounts.Where(x => x.Id == id).Select(x =>
            new Balance(x.Limite, DateTime.UtcNow, x.Saldo)).Single();

        var LastTransactions = _context.Transactions
            .Where(x => x.ClientId == id)
            .OrderByDescending(x => x.Date)
            .Take(10);

        return new BankAccountStatement(balance, LastTransactions);
    }
}