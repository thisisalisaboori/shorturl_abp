using AutoMapper;
using ShortUrl.Application.Contracts.Link;
using ShortUrl.Domain.Link;

namespace ShortUrl;

public class ShortUrlApplicationAutoMapperProfile : Profile
{
    public ShortUrlApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

         CreateMap<CreateLink,Link>();
         CreateMap<Link,LinkDto>();

    }
}
