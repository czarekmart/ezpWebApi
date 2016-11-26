using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EasyPower.Web.Api.Controllers
{
    public abstract class EquipmentController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetItems()
        {
            return Ok(new { Url = "getItems" });
        }

        [HttpGet]
        [Route("{dba}")]
        public IHttpActionResult GetItem(int dba)
        {
            return Ok(new { Url = "getItem", Addr = dba });
        }
    }
}
