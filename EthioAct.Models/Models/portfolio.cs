using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class portfolio
    {
        public portfolio()
        {
            this.portfolioVSImages = new List<portfolioVSImage>();
            this.portfolioVSVideos = new List<portfolioVSVideo>();
        }

        public int portfolioId { get; set; }
        public string portfolioName { get; set; }
        public string description { get; set; }
        public Nullable<int> portfolioTypeId { get; set; }
        public virtual PortfolioType PortfolioType { get; set; }
        public virtual ICollection<portfolioVSImage> portfolioVSImages { get; set; }
        public virtual ICollection<portfolioVSVideo> portfolioVSVideos { get; set; }
    }
}
