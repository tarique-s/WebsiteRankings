using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebSiteRanking.Common;
using WebSiteRanking.Repository;

namespace WebSiteRankingApi.Controllers
{
    [Route("api/[controller]")]

    public class WebsitesController : Controller
    {
        #region Fields and Properties

        private IWebsiteRepository _repository;

        #endregion

        #region .ctor
        
        public WebsitesController(IWebsiteRepository repository)
        {
            _repository = repository;
        }

        #endregion

        #region Public Methods

        [HttpGet("{date}/{count}")]
        public IEnumerable<WebsiteDto> Get(string date,int count)
        {
            DateTime visitDate = DateTime.Parse(date);
            return _repository.GetTopWebsitesByDate(visitDate,count);
        }


        #endregion
    }
}