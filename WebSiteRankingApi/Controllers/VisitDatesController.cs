using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebSiteRanking.Repository;

namespace WebSiteRankingApi.Controllers
{
    //[EnableCors("CORSPolicy")]
    [Route("api/[controller]")]

    public class VisitDatesController : Controller
    {
        #region Fields and Properties

        private IWebsiteRepository _repository;

        #endregion

        #region .ctor

        public VisitDatesController(IWebsiteRepository repository)
        {
            _repository = repository;
        }

        #endregion

        // GET: api/VisitDates
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _repository.GetVisitDates();
        }

        
    }
}
