using System;

namespace Cloud5mins.domain
{
    public class ShortResponse
    {
        public string ShortUrl { get; set; }
        public string LongUrl { get; set; }
        public string Title { get; set; }

        public bool IsDeleted { get; set; }

        public ShortResponse(){}
        public ShortResponse (string host, string longUrl, string endUrl, string title, bool isdeleted)
        {
            LongUrl = longUrl;
            ShortUrl = string.Concat(host, "/", endUrl);
            Title = title;
            IsDeleted = isdeleted;
        }
    }
}