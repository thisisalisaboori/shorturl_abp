using System;
using System.Collections.Generic;
using System.Text;
using ShortUrl.Localization;
using Volo.Abp.Application.Services;

namespace ShortUrl;

/* Inherit your application services from this class.
 */
public abstract class ShortUrlAppService : ApplicationService
{
    protected ShortUrlAppService()
    {
        LocalizationResource = typeof(ShortUrlResource);
    }
}
