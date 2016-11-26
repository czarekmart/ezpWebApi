using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyPower.Web.Api.Controllers
{
    [RoutePrefix("api/debug/mock")]
    public class MockController : ApiController
    {
        [Route("cables/{id?}")]
		[HttpGet]
        public IHttpActionResult GetMotorCables(int id = -1)
        {
            return Ok(new { Url = "api/debug/mock/cables", Id = id } );
        }
    }
}
