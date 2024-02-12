using Domain.Transactions;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/clientes/{id}/transacoes", async (int id, TransactionDto transactionDto, HttpContext http) =>
{
    // Logic

    return Results.Ok(new { Message = "Transaction created successfully", ClientId = id, TransactionDetails = transactionDto });
});

app.Run();
