using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ShortUrl.Data;

/* This is used if database provider does't define
 * IShortUrlDbSchemaMigrator implementation.
 */
public class NullShortUrlDbSchemaMigrator : IShortUrlDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
