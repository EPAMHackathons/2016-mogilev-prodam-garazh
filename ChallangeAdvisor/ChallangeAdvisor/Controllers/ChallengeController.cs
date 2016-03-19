using BusinessOperations;
using Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Http.Cors;

namespace ChallangeAdvisor.Controllers
{
    [RoutePrefix("api/Challenge")]
    public class ChallengeController : ApiController
    {
        [Route("GetChallenges")]
        [HttpGet]
        public JsonResult<List<ChallengeBreifViewModel>> GetChallenges()
        {
            List<ChallengeBreifViewModel> model = new List<ChallengeBreifViewModel>()
            {
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },
                new ChallengeBreifViewModel() { Author="unnamed", Description="fissh text", AvatarLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",ImageLink="http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg", Tags = new string[] {"tag","tag","tag"} },

            };

            return Json(model);
        }
        [Route("GetRemainingChallenges"), ]
        [HttpGet]
        public IEnumerable<string> GetRemainingChallenges(int page)
        {
            return new string[] { "value1", "value2" };
        }
        [Route("GetChallenge")]
        [HttpGet]
        public JsonResult<ChallengeDetailViewModel> GetChallenge(int id)
        {
            ChallengeDetailViewModel model = new ChallengeDetailViewModel()
            {
                Title = "Title",
                Author = "Author",
                Description = "description",
                ImagesLink = "http://www.gettyimages.ca/gi-resources/images/Homepage/Category-Creative/UK/UK_Creative_462809583.jpg",
                Latitude = 50,
                Longitude = 50,
                PostId = 5,
                Stories = new List<StoryListItemViewModel>() { new StoryListItemViewModel() { StoryId = 1, Title = "Story title" }, new StoryListItemViewModel() { StoryId = 1, Title = "Story title" }, new StoryListItemViewModel() { StoryId = 1, Title = "Story title" }, new StoryListItemViewModel() { StoryId = 1, Title = "Story title" } },
                Tags = new string[] { "tag", "tag", "tag" }
            };
            return Json(model);
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
        [HttpPost]
        public void CreateChallenge(ChallengeAddViewModel model)
        {
            ChallengeMapping mapping = ChallengeMapping.GetInstance();
            bool status = mapping.AddNewChallange(model);
        }

    }
}
