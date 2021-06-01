using AirVinyl.DataAccessLayer;
using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace AirVinylAPI.Controllers
{
    public class PeopleController : ODataController
    {
        private AirVinylDbContext _ctx = new AirVinylDbContext();

        public IHttpActionResult Get()
        {
            return Ok(_ctx.People );
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
            base.Dispose(disposing);
        }
    }
}