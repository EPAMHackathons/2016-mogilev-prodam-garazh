using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChallangeAdvisor.Controllers
{
    [RoutePrefix("api/Challenge")]
    public class ChallengeController : ApiController
    {
        [Route("GetChallenges")]
        [HttpGet]
        public IEnumerable<string> GetChallenges()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetRemainingChallenges")]
        [HttpGet]
        public IEnumerable<string> GetRemainingChallenges(int page)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetChallenge")]
        [HttpGet]
        public IEnumerable<string> GetChallenge(int challengeId)
        {
            return new string[] { "value1", "value2" };
        }

        [Route("GetChallengeStories")]
        [HttpGet]
        public IEnumerable<string> GetChallengeStories()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("AcceptChallenge")]
        [HttpGet]
        public void AcceptChallenge(int challengeId)
        {

        }
        [Route("CreateChallenge")]
        [HttpGet]
        public void CreateChallenge()
        {

        }
        
    }
}
