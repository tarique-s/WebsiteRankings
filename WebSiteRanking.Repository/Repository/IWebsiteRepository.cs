using System;
using System.Collections.Generic;
using WebSiteRanking.Common;

namespace WebSiteRanking.Repository
{
    public interface IWebsiteRepository
    {
        IList<WebsiteDto> GetTopWebsitesByDate(DateTime date);
    }
}