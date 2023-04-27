using ShortUrl.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ShortUrl.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ShortUrlController : AbpControllerBase
{
    protected ShortUrlController()
    {
        LocalizationResource = typeof(ShortUrlResource);
    }
}
