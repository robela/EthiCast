using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class Image
    {
        public Image()
        {
            this.ActorVSImages = new List<ActorVsImage>();
            this.portfolioVSImages = new List<portfolioVSImage>();
        }

        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public string imageURL { get; set; }
        public Nullable<int> imageTypeId { get; set; }
        public string description { get; set; }
        public virtual ICollection<ActorVsImage> ActorVSImages { get; set; }
        public virtual ImageType ImageType { get; set; }
        public virtual ICollection<portfolioVSImage> portfolioVSImages { get; set; }
    }
}
