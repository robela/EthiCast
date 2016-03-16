using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class portfolioVSVideo
    {
        public int portfolioVsVideoId { get; set; }
        public int portfolioId { get; set; }
        public int VideoId { get; set; }
        public virtual portfolio portfolio { get; set; }
        public virtual Video Video { get; set; }
    }
}
