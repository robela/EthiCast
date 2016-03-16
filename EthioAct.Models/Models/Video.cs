using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class Video
    {
        public Video()
        {
            this.ActorVSVideos = new List<ActorVSVideo>();
            this.portfolioVSVideos = new List<portfolioVSVideo>();
        }

        public int videoId { get; set; }
        public Nullable<int> videoTypeId { get; set; }
        public string videoURl { get; set; }
        public string description { get; set; }
        public virtual ICollection<ActorVSVideo> ActorVSVideos { get; set; }
        public virtual ICollection<portfolioVSVideo> portfolioVSVideos { get; set; }
        public virtual VideoType VideoType { get; set; }
    }
}
