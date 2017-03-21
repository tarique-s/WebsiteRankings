using System;
using System.Collections.Generic;

namespace WebSiteRanking.Repository
{
    public partial class WebsiteVisit
    {
        public int WebsiteVisitId { get; set; }
        public DateTime Date { get; set; }
        public int WebsiteId { get; set; }
        public long VisitCount { get; set; }

        public virtual Website Website { get; set; }
    }
}
