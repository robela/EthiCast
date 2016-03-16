using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class ActorVSVideo
    {
        public int actorVsVideoId { get; set; }
        public int actorId { get; set; }
        public int videoId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Video Video { get; set; }
    }
}
