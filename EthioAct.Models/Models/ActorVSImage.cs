using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class ActorVsImage
    {
        public int actorVsImageId { get; set; }
        public int actorId { get; set; }
        public int ImageId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Image Image { get; set; }
    }
}
