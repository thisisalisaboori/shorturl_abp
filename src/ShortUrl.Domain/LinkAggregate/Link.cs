using Volo.Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;
namespace ShortUrl.Domain.Link
{
    public class Link: AggregateRoot<int>
    {
        const string chars = "qwertyuiopasdfghjklmnbvcxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string Url{get;set;}
        [MaxLength(5)]
        public string ShortUrl{get;set;}

    }

}