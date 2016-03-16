using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class VideoType
    {
        public VideoType()
        {
            this.Videos = new List<Video>();
        }

        public int videoTypeId { get; set; }
        public string videoTypeName { get; set; }
        public string description { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
