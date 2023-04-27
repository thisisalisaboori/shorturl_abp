using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShortUrl.Data;
using Volo.Abp.DependencyInjection;

namespace ShortUrl.EntityFrameworkCore;

public class EntityFrameworkCoreShortUrlDbSchemaMigrator
    : IShortUrlDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreShortUrlDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ShortUrlDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ShortUrlDbContext>()
            .Database
            .MigrateAsync();
    }
}
