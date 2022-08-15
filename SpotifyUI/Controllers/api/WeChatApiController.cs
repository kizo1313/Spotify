using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpotifyUI.Areas.QianTai.Controllers.api
{
    public class WeChatApiController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Json("Get");
        }
        public IHttpActionResult Post()
        {
            return Json("Post");
        }
        public IHttpActionResult Put()
        {
            return Json("Put");
        }
        public IHttpActionResult Delete()
        {
            return Json("Delete");
        }
    }
}
