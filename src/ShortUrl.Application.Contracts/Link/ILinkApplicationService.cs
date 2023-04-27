using System.Threading.Tasks;
using Volo.Abp.Application;
using Volo.Abp.Application.Services;

namespace ShortUrl.Application.Contracts.Link
{
    public interface ILinkApplicationService:IApplicationService
    {
        Task<LinkDto> Create(CreateLink obj);
        Task<LinkDto> GetLink(string link);
    }
}