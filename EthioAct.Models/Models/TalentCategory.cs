using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class TalentCategory
    {
        public TalentCategory()
        {
            this.Talents = new List<Talent>();
            this.talentValues = new List<talentValue>();
        }

        public int talentCategoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public virtual ICollection<Talent> Talents { get; set; }
        public virtual ICollection<talentValue> talentValues { get; set; }
    }
}
