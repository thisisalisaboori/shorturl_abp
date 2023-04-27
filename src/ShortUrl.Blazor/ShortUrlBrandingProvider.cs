using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ShortUrl.Blazor;

[Dependency(ReplaceServices = true)]
public class ShortUrlBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ShortUrl";
}
