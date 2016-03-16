using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class portfolioVSImage
    {
        public int portfolioVsImageId { get; set; }
        public int portfolioId { get; set; }
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }
        public virtual portfolio portfolio { get; set; }
    }
}
