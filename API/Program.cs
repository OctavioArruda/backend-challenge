using Domain.Accounts;
using Domain.Contracts.Interfaces.Services;
using Domain.Transactions;
using Infrastructure.Database.ApplicationContext;
using Infrastructure.DependencyInjection;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRepositories();
builder.Services.AddServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/clientes/{id}/transacoes", async ([FromRoute] long id,
    Transaction transaction,
    HttpContext http,
    ITransactionService _transactionService) =>
{
    await _transactionService.Process(transaction, clientId: id);

    return Results.Ok(new { Message = "Transaction created successfully", ClientId = id, Account = new Account(100, 100, 100) });
});

app.MapGet("/clientes/{id}/extrato", async ([FromRoute] long id,
    HttpContext http,
    IAccountStatementService _accountStatementService) =>
{
    return Results.Ok(_accountStatementService.Get(id));
});

app.Run();