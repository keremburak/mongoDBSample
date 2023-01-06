using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Settings;

namespace Utilities.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDbSettings(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<MongoDBSettings>(options =>
            {
                options.ConnectionString = configuration?
                    .GetSection(nameof(MongoDBSettings) + ":" + MongoDBSettings.ConnectionStringValue).Value;
                options.Database = configuration?
                    .GetSection(nameof(MongoDBSettings) + ":" + MongoDBSettings.DatabaseValue).Value;
            });
        }
    }
}
