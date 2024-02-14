using Application.Implementations.Services;
using Domain.Contracts.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class RegisterServices
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAccountStatementService, AccountStatementService>();
        services.AddScoped<ITransactionService, TransactionService>();

        return services;
    }
}