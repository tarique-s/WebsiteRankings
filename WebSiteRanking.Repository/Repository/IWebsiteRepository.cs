using System;
using System.Collections.Generic;
using WebSiteRanking.Common;

namespace WebSiteRanking.Repository
{
    public interface IWebsiteRepository
    {
        IList<string> GetVisitDates();
        IList<WebsiteDto> GetTopWebsitesByDate(DateTime date, int count);
    }
}