using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class Talent
    {
        public Talent()
        {
            this.ActorVsTalents = new List<ActorVsTalent>();
        }

        public int talentId { get; set; }
        public Nullable<int> talentCategoryId { get; set; }
        public string talentName { get; set; }
        public string description { get; set; }
        public virtual ICollection<ActorVsTalent> ActorVsTalents { get; set; }
        public virtual TalentCategory TalentCategory { get; set; }
    }
}
