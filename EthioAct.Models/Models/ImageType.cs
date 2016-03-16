using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class ImageType
    {
        public ImageType()
        {
            this.Images = new List<Image>();
        }

        public int imageTypeId { get; set; }
        public string imageTypeName { get; set; }
        public string description { get; set; }
        public virtual ICollection<Image> Images { get; set; }
    }
}
