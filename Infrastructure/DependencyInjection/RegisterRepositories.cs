using Domain.Contracts.Interfaces.Repositories;
using Infrastructure.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyInjection;

public static class RegisterRepositories
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAccountStatementRepository, AccountStatementRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();

        return services;
    }
}