using Volo.Abp.Application.Dtos;
using System.ComponentModel.DataAnnotations;
namespace ShortUrl.Application.Contracts.Link
{
    public class LinkDto:EntityDto<int>
    {
        public string Url{get;set;}
        [MaxLength(5)]
        public string ShortUrl{get;set;}
    }
}