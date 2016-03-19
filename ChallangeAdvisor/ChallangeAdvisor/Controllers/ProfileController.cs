using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChallangeAdvisor.Controllers
{
    [RoutePrefix("api/Profile")]
    public class ProfileController : ApiController
    {
        
        [Route("GetProfile")]
        [HttpGet]
        public IEnumerable<string> GetProfile(int? userId)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("SaveProfile")]
        [HttpGet]
        public IEnumerable<string> SaveProfile()
        {
            return new string[] { "value1", "value2" };
        }
    }
}