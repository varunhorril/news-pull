using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Models
{
    public class SearchFields
    {
        public string Thumbnail { get; set; }
        public DateTime LastModified { get; set; }
        public string ShortUrl { get; set; }
        public bool IsPremoderated { get; set; }
        public int WordCount { get; set; }
        public float Score { get; set; }
    }
}
