using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class talentValue
    {
        public talentValue()
        {
            this.ActorVsTalents = new List<ActorVsTalent>();
        }

        public int talentValueId { get; set; }
        public string value { get; set; }
        public string description { get; set; }
        public Nullable<int> talentCategoryId { get; set; }
        public virtual ICollection<ActorVsTalent> ActorVsTalents { get; set; }
        public virtual TalentCategory TalentCategory { get; set; }
    }
}
