using System.Threading.Tasks;

namespace ShortUrl.Data;

public interface IShortUrlDbSchemaMigrator
{
    Task MigrateAsync();
}
