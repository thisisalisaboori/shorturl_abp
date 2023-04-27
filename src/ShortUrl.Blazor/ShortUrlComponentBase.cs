using ShortUrl.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ShortUrl.Blazor;

public abstract class ShortUrlComponentBase : AbpComponentBase
{
    protected ShortUrlComponentBase()
    {
        LocalizationResource = typeof(ShortUrlResource);
    }
}
