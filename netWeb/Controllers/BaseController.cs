using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace netWeb.Controllers
{
    public abstract class BaseController : ApiController
    {
        [HttpGet, Route("findOne")]
        public string findOne(string id)
        {
            return "QQ:511570155";
        }
    }
}