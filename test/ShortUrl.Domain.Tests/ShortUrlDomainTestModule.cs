using ShortUrl.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ShortUrl;

[DependsOn(
    typeof(ShortUrlEntityFrameworkCoreTestModule)
    )]
public class ShortUrlDomainTestModule : AbpModule
{

}
