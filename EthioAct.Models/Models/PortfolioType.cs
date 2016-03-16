using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class PortfolioType
    {
        public PortfolioType()
        {
            this.portfolios = new List<portfolio>();
        }

        public int portfolioTypeID { get; set; }
        public string portfolioTypeName { get; set; }
        public string description { get; set; }
        public virtual ICollection<portfolio> portfolios { get; set; }
    }
}
