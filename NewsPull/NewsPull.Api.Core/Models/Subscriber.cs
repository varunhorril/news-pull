using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPull.Api.Core.Models
{
    public class Subscriber : AuditBase
    {
        public Guid SubscriberId { get; set; }
        public string Email { get; set; }
        public int Frequency { get; set; }
        public string Topic { get; set; }
    }
}
