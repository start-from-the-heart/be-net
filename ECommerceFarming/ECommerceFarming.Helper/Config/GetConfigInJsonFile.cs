using Microsoft.Extensions.Configuration;

namespace ECommerceFarming.Helper.Config
{
    public static class GetConfigInJsonFile
    {
        public static IConfigurationRoot Load()
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../ECommerceFarming.Infrastructure");
            var config = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("Common/Appsettings.Develop.json", optional: false, reloadOnChange: true)
                .Build();

            return config;
        }
    }
}