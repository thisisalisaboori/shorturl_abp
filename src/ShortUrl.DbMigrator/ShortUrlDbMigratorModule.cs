using ShortUrl.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ShortUrl.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShortUrlEntityFrameworkCoreModule),
    typeof(ShortUrlApplicationContractsModule)
    )]
public class ShortUrlDbMigratorModule : AbpModule
{

}
