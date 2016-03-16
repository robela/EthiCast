using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class ActorRequirement
    {
        public int actorRequirementId { get; set; }
        public string requirementId { get; set; }
        public string description { get; set; }
        public string castingId { get; set; }
    }
}
