using Volo.Abp.Modularity;

namespace ShortUrl;

[DependsOn(
    typeof(ShortUrlApplicationModule),
    typeof(ShortUrlDomainTestModule)
    )]
public class ShortUrlApplicationTestModule : AbpModule
{

}
