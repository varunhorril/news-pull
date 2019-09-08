using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Models
{
    public class SearchResult
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string SectionId { get; set; }
        public string SectionName { get; set; }
        public DateTime WebPublicationDate { get; set; }
        public bool Commentable { get; set; }
        public int StarRating { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public string ApiUrl { get; set; }
        public bool Hosted { get; set; }
        public string PillarId { get; set; }
        public string PillarName { get; set; }

        public SearchFields Fields { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
