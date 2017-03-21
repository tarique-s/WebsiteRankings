using System;
using System.Collections.Generic;
using System.Linq;
using WebSiteRanking.Common;

namespace WebSiteRanking.Repository
{
    public class WebsiteRepository : IWebsiteRepository
    {
        private WebsiteContext _context;

        public WebsiteRepository(WebsiteContext context)
        {
            _context = context;
        }

        public IList<string> GetVisitDates()
        {
            var dates = _context.WebsiteVisit.Select(wv => wv.Date)
                                             .OrderByDescending(wv=>wv.Date)
                                             .Distinct()
                                             .ToList();

            return dates.Select(date => date.ToString("yyyy-MM-dd")).ToList();

        }

        public IList<WebsiteDto> GetTopWebsitesByDate(DateTime date)
        {            
            return _context.WebsiteVisit.Where(wv => wv.Date == date)
                                        .Select(wv => new WebsiteDto { Website = wv.Website.Website1, VisitCount = wv.VisitCount })
                                        .OrderByDescending(dto=>dto.VisitCount)
                                        .ToList();            
        }

    }
}
