using Contracts.Entities;
using Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessOperations
{
    public class ChallengeMapping
    {
        public static ChallengeMapping GetInstance()
        {
            return new ChallengeMapping();
        }

        public bool AddNewChallange(ChallengeAddViewModel model)
        {
            List<Content> assets = new List<Content>();
            foreach (var item in model.VideosLink)
            {
                assets.Add(new Content() { Type = Enums.ContentType.Video, Address = item });
            }
            foreach (var item in model.ImagesLink)
            {
                assets.Add(new Content() { Type = Enums.ContentType.Image, Address = item });
            }
            Post post = new Post();
            post.Title = model.Title;
            post.Text = model.Description;
            post.Stories = new List<Story>();
            post.Stories.Add(new Story() { User = new User() { Id = 1 }, Approved=false, StoryText=model.Story, ContentCollection = assets, CompletionStatus= Enums.CompletionStatus.Completed,  });
            post.Author = new User() { Id = 1 };
            post.ImageLink = model.ImageLink;
            post.Latitude = model.Latitude;
            post.Longitude = model.Longitude;
            post.Approved = true;
            return true;
        }
    }
}
