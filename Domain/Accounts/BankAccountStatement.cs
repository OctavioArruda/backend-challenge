using Domain.Accounts;
using Domain.Transactions;

public record BankAccountStatement(Balance Balance, IEnumerable<Transaction> UltimasTransacoes);