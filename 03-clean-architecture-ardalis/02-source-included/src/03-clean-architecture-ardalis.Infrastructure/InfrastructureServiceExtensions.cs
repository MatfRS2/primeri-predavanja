using _03_clean_architecture_ardalis.Core.Interfaces;
using _03_clean_architecture_ardalis.Core.Services;
using _03_clean_architecture_ardalis.Infrastructure.Data;
using _03_clean_architecture_ardalis.Infrastructure.Data.Queries;
using _03_clean_architecture_ardalis.UseCases.Contributors.List;


namespace _03_clean_architecture_ardalis.Infrastructure;
public static class InfrastructureServiceExtensions
{
  public static IServiceCollection AddInfrastructureServices(
    this IServiceCollection services,
    ConfigurationManager config,
    ILogger logger)
  {
    string? connectionString = config.GetConnectionString("SqliteConnection");
    Guard.Against.Null(connectionString);
    services.AddDbContext<AppDbContext>(options =>
     options.UseSqlite(connectionString));

    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>))
           .AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>))
           .AddScoped<IListContributorsQueryService, ListContributorsQueryService>()
           .AddScoped<IDeleteContributorService, DeleteContributorService>();


    logger.LogInformation("{Project} services registered", "Infrastructure");

    return services;
  }
}
