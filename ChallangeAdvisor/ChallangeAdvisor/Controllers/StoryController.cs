using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChallangeAdvisor.Controllers
{
    [RoutePrefix("api/Story")]
    public class StoryController : ApiController
    {
        [Route("GetStory")]
        [HttpGet]
        public IEnumerable<string> GetStory(int storyId)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetStoriesByUser")]
        [HttpGet]
        public IEnumerable<string> GetStoriesByUser(string nickname)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetStoryByUser")]
        [HttpGet]
        public IEnumerable<string> GetStoryByUser(string nickname)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetMyStories")]
        [HttpGet]
        public IEnumerable<string> GetMyStories()
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetMyStory")]
        [HttpGet]
        public IEnumerable<string> GetMyStory(int storyId)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("StatusChanging")]
        [HttpGet]
        public IEnumerable<string> StatusChanging(int statusId)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("SaveStory")]
        [HttpGet]
        public IEnumerable<string> SaveStory(/*object*/)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("DeleteStory")]
        [HttpGet]
        public IEnumerable<string> DeleteStory(int storyId)
        {
            return new string[] { "value1", "value2" };
        }

    }
}
