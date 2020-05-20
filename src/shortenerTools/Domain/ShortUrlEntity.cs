using System.Linq;
using Microsoft.Azure.Cosmos.Table;

namespace Cloud5mins.domain
{
    public class ShortUrlEntity : TableEntity
    {
        //public string Id { get; set; }
        public string Url { get; set; }

        public string Title { get; set; }

        public string ShortUrl { get; set; }

        public int Clicks { get; set; }

        public bool IsDeleted { get; set; }

        public ShortUrlEntity(){}

        public ShortUrlEntity(string longUrl, string endUrl, bool isdeleted)
        {
            Initialize(longUrl, endUrl, string.Empty, isdeleted);
        }

        public ShortUrlEntity(string longUrl, string endUrl, string title, bool isdeleted)
        {
            Initialize(longUrl, endUrl, title, isdeleted);
        }

        private void Initialize(string longUrl, string endUrl, string title, bool isdeleted){
            PartitionKey = endUrl.First().ToString();
            RowKey = endUrl;
            Url = longUrl;
            Title = title;
            Clicks = 0;
            IsDeleted = isdeleted;
        }

        public static ShortUrlEntity GetEntity(string longUrl, string endUrl){
            return new ShortUrlEntity
            {
                PartitionKey = endUrl.First().ToString(),
                RowKey = endUrl,
                Url = longUrl
            };
        }
    }


}
