using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Models
{
    public class Tag
    {
        public string Id { get; set; }
        public string SectionId { get; set; }
        public string SectionName { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public string Type { get; set; }
    }
}
