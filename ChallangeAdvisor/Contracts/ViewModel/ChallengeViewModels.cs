﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.ViewModel
{
    public class ChallengeBreifViewModel
    {
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string[] Tags { get; set; }
        public string AvatarLink { get; set; }
    }
    public class ChallengeDetailViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ImagesLink { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string[] Tags { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<StoryListItemViewModel> Stories { get; set; }
    }
   public class ChallengeAddViewModel
    {
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public string[] ImagesLink { get; set; }
        public string[] VideosLink { get; set; }
        public string Story { get; set; }
        public int Status { get; set; } // complete
        public int Author { get; set; }
        public int[] TagsId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
    public class ChallengeSaveViewModel
    {
        public int ChallengeId { get; set; }
        public string Title { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public MediaFile[] ImagesLink { get; set; }
        public MediaFile[] VideosLink { get; set; }
        public string Story { get; set; }
        public int StoryId { get; set; }
        public int Status { get; set; } // complete
        public Guid Author { get; set; }
        public int[] TagsId { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
