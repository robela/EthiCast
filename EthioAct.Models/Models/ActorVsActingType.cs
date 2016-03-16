using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class ActorVsActingType
    {
        public int actorVsActingTypeId { get; set; }
        public int actorId { get; set; }
        public int actingTypeId { get; set; }
    }
}
