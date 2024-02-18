using Domain.Accounts;
using Domain.Contracts.Interfaces.Services;
using Domain.Transactions;
using Infrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRepositories();
builder.Services.AddServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/clientes/{id}/transacoes", async (long id,
    Transaction transaction,
    HttpContext http,
    ITransactionService _transactionService) =>
{
    // TODO: Logic
    await Task.Run(() =>
    {
        Console.WriteLine("test");
    });

    await _transactionService.Process(transaction);

    return Results.Ok(new { Message = "Transaction created successfully", ClientId = id, Account = new Account(100, 100) });
});

app.MapGet("/clientes/{id}/extrato", async (long id,
    HttpContext http,
    IAccountStatementService _accountStatementService) =>
{
    // TODO
    await Task.Run(() =>
    {
        Console.WriteLine("test");
    });

    await _accountStatementService.Get(id);

    return Results.Ok(new BankAccountStatement(new Balance(1, DateTime.UtcNow, 1), new List<Transaction>()));
});

app.Run();