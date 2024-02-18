using Domain.Accounts;
using Domain.Contracts.Interfaces.Repositories;
using Domain.Transactions;
using Infrastructure.Database.ApplicationContext;

namespace Infrastructure.Database.Repositories;

public sealed class TransactionRepository : ITransactionRepository
{
    private readonly ApplicationDbContext _context;

    public TransactionRepository(ApplicationDbContext context)
    {
        _context = context;
    }


    public Task<Account> Process(Transaction transaction, long clientId)
    {
        var transactionToSave = new Transaction(valor: transaction.Valor, tipo: transaction.Tipo, descricao: transaction.Descricao, clientId: clientId);
        _context.Transactions.Add(transactionToSave);
        _context.SaveChanges();
        return Task.FromResult(new Account(100, 100, 100));
    }
}