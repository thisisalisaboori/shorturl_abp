
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using ShortUrl.Application.Contracts.Link;
using ShortUrl.Domain.Link;
using Volo.Abp.Application;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System;
namespace ShortUrl.Application
{
    public class LinkApplicationService : ApplicationService, ILinkApplicationService
    {
        
        private readonly IRepository<Link, int> _repository;
        
        public LinkApplicationService(IRepository<Link, int> repository)
        {
            _repository = repository;
        }

        public async Task<LinkDto> Create(CreateLink obj)
        {
            var newObj = this.ObjectMapper.Map<CreateLink, Link>(obj);
            newObj.ShortUrl = Link.RandomString(5);
            await this._repository.InsertAsync(newObj);
            var result = this.ObjectMapper.Map<Link, LinkDto>(newObj);
            return result;
        }
        public async Task<LinkDto> GetLink(string link)
        {
            var q = await this._repository.GetQueryableAsync();
            var res =  q.Where(x => x.ShortUrl == link).
            Select(x => new LinkDto()
            {
                ShortUrl = x.ShortUrl,
                Url = x.Url
            }).FirstOrDefault();
            if(res == null){
                return new LinkDto();
            }
            return res;
        }
    }
}