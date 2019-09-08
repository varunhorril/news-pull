using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Models
{
    public class Section
    {
        public string Id { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public IList<SectionEdition> Editions { get; set; }

    }
}
