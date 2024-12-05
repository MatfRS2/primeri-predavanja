using Serilog;

namespace _03_clean_architecture_ardalis.Web.Configurations;

public static class LoggerConfigs
{
  public static WebApplicationBuilder AddLoggerConfigs(this WebApplicationBuilder builder)
  {

    builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));

    return builder;
  }
}
