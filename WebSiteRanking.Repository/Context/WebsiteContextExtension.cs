using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebSiteRanking.Repository
{
    public partial class WebsiteContext : DbContext
    {
        public WebsiteContext(DbContextOptions options) : base(options) { }
    }
}
