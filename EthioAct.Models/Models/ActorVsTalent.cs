using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class ActorVsTalent
    {
        public int actorVsTalent1 { get; set; }
        public int actorId { get; set; }
        public int talentId { get; set; }
        public int talentValueId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Talent Talent { get; set; }
        public virtual talentValue talentValue { get; set; }
    }
}
