using Domain.Accounts;
using Domain.Transactions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/clientes/{id}/transacoes", async (long id, Transaction transactionDto, HttpContext http) =>
{
    // TODO: Logic
    await Task.Run(() => {
        Console.WriteLine("test");
    });

    return Results.Ok(new { Message = "Transaction created successfully", ClientId = id, Account = new Account(100, 100) });
});

app.Run();