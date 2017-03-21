using System;
using System.Collections.Generic;

namespace WebSiteRanking.Repository
{
    public partial class Website
    {
        public Website()
        {
            WebsiteVisit = new HashSet<WebsiteVisit>();
        }

        public int WebsiteId { get; set; }
        public string Website1 { get; set; }

        public virtual ICollection<WebsiteVisit> WebsiteVisit { get; set; }
    }
}
